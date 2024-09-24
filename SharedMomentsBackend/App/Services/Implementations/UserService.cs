using AuthManagerLibrary.App.Definitions;
using AuthManagerLibrary.App.Models;
using AutoMapper;
using CustomStorageLibrary.App.Interfaces;
 
using EncryptifyLibrary.App.Interfaces;
using Microsoft.EntityFrameworkCore;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Resource;
using SharedMomentsBackend.App.Models.DTOs.User;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Models.Entities.Security;
using SharedMomentsBackend.App.Services.Interfaces;
 

namespace SharedMomentsBackend.App.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private IEncryptService _encryptService;
        private IAuthenticationService _authenticationService;
        IUserRepository _userRepository;
        IRoleRepository _roleRepository;
        IResourceRepository _resourceRepository;
        IResourceManager _resourceManager;
        IUnitOfWork _unitOfWork;
        IWebHostEnvironment _hostingEnvironment;
        IUserFriendRepository _userFriendRepository;
        public UserService(
            IUserRepository userRepository,
            IMapper mapper,
            IEncryptService encryptService,
            IAuthenticationService authenticationService,
            IRoleRepository roleRepository,
            IResourceRepository resourceRepository,
            IResourceManager resourceManager,
            IUnitOfWork unitOfWork,
            IWebHostEnvironment hostingEnvironment,
            IUserFriendRepository userFriendRepository
            )
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _encryptService = encryptService;
            _authenticationService = authenticationService;
            _roleRepository = roleRepository;
            _resourceManager = resourceManager;
            _resourceRepository = resourceRepository;
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
            _userFriendRepository = userFriendRepository;
        }
        public async Task<ResultPattern<LoginResponse>> Login(LoginRequest request)
        {
            ResultPattern<LoginResponse> response = new ResultPattern<LoginResponse>();
            request.Password = _encryptService.Encrypt(request.Password);
            bool existUser = await _userRepository.Exists(x => x.Email.Equals(request.Email) && x.PasswordHash.Equals(request.Password));
            if (!existUser)
            {
                response.Message = "Correo o contraseña incorrectos.";
                response.IsSuccess = false;
                response.StatusCode = 401;
                return response;
            }
            User user = await _userRepository.Login(request);
            response.Data = _mapper.Map<LoginResponse>(user);
            response.Data.Token = _authenticationService.Authenticate(new AuthenticationDataRequest
            {
                UserId = user.Id.ToString(),
                UserName = user.Name
            });
            return response;
        }

        public async Task<ResultPattern<UserResponse>> Register(UserRequest request)
        {
            ResultPattern<UserResponse> response = new ResultPattern<UserResponse>();

            if (await _userRepository.Exists(x => x.Email == request.Email))
            {
                response.Message = "El correo ingresado ya está en uso.";
                response.StatusCode = 409; // Código de estado 409 Conflict
                response.IsSuccess = false;
                return response;
            }

            if (await _userRepository.Exists(x => x.PhoneNumber == request.PhoneNumber))
            {
                response.Message = "El teléfono ingresado ya está en uso.";
                response.StatusCode = 409; // Código de estado 409 Conflict
                response.IsSuccess = false;
                return response;
            }

            request.PasswordHash = _encryptService.Encrypt(request.PasswordHash);
            if (!request.RoleId.HasValue)
            {
                Role role = await _roleRepository.GetFirstOrDefault(x => x.Name.Equals("User"));
                request.RoleId = role.Id;
            }
            User user = _mapper.Map<User>(request);
            await _userRepository.Add(user);

            response.Data = _mapper.Map<UserResponse>(user);
            response.Message = "Usuario registrado correctamente.";
            response.Data.Token = _authenticationService.Authenticate(new AuthenticationDataRequest
            {
                UserId = user.Id.ToString(),
                UserName = user.Name
            });
            return response;
        }
        public async Task<ResultPattern<IEnumerable<DataDropdownUser>>> DataDropDownFriends(DefaultFilterParams filterParams, Guid currentUserId)
        {
            ResultPattern<IEnumerable<DataDropdownUser>> response = new ResultPattern<IEnumerable<DataDropdownUser>>();

            IEnumerable<UserFriend> users = await _userFriendRepository
                .GetAll(filter: x => x.UserId == currentUserId, null, $"{nameof(UserFriend.Friend)}.{nameof(User.Profile)}");

            response.Data =  users.Select(x => new DataDropdownUser
            {
                Id = x.FriendId,
                Label = x.Friend.Name,
                ProfileUrl = x.Friend.Profile?.Url
            });
            return response;
        }
        public async Task<ResultPattern<IEnumerable<DataDropdownUser>>> DataDropDownNoFriends(DefaultFilterParams filterParams, Guid currentUserId)
        {
            ResultPattern<IEnumerable<DataDropdownUser>> response = new ResultPattern<IEnumerable<DataDropdownUser>>();

            IQueryable<User> allUsers = _unitOfWork.Context.Users.AsQueryable().Include(x=>x.Profile).Where(x=>x.Id!=currentUserId);

            IQueryable<Guid> friendIds = _unitOfWork.Context.UserFriends.Where(x => x.UserId == currentUserId).Select(x => x.FriendId);

            IQueryable<User> usersNotInFriends = allUsers.Where(x => !friendIds.Contains(x.Id));

            response.Data = usersNotInFriends.Select(x => new DataDropdownUser
            {
                Id = x.Id,
                Label = x.Name,
                ProfileUrl = x.Profile != null ? x.Profile.Url : null
            });
            return response;
        }
        public async Task<ResultPattern<ProfileResponse>> GetProfile(Guid userId)
        {
            ResultPattern<ProfileResponse> response = new ResultPattern<ProfileResponse>();
            User user = await _userRepository.GetFirstOrDefault(x => x.Id == userId,$"{nameof(User.Profile)}");
            ProfileResponse profile = _mapper.Map<ProfileResponse>(user);

            response.Data = profile;
            return response;
        }

        public async Task<ResultPattern<ProfileResponse>> UpdateProfile(Guid userId, ProfileRequest request)
        {
            ResultPattern<ProfileResponse> response = new ResultPattern<ProfileResponse>();

            if (!await _userRepository.Exists(x => x.Id == userId))
            {
                response.StatusCode = 404;
                response.Message = "Usuario no encontrado.";
                response.IsSuccess = false;
                return response;
            }

            User user = await _userRepository.GetFirstOrDefault(x => x.Id == userId, $"{nameof(User.Profile)}");

            if (request.Profile is not null)
            {
               if(user.Profile is not null)
                {
                    await _resourceManager.DeleteFile("users", user.Profile.Name, user.Profile.Extension);
                    await _resourceRepository.Delete(user.Profile.Id);
                }

                MemoryStream memoryStream = new MemoryStream();
                await request.Profile.CopyToAsync(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);
                ResourceRequest newResourceRequest = new ResourceRequest
                {
                    Stream = memoryStream,
                    ContentType = request.Profile.ContentType,
                    Extension = Path.GetExtension(request.Profile.FileName)
                };
                CustomStorageLibrary.App.Models.Resource newResourceUploaded = await _resourceManager.UploadFile(
                    newResourceRequest.Stream,
                    $"{_hostingEnvironment.EnvironmentName}/users",
                    newResourceRequest.ContentType,
                    user.Id.ToString(),
                    newResourceRequest.Extension
                    );

                Resource newResource = new Resource
                {
                    Name = newResourceUploaded.Name,
                    Url = newResourceUploaded.Url,
                    Extension = newResourceUploaded.Extension,
                    Path = newResourceUploaded.Path,
                    Size = newResourceUploaded.Size,
                };
                user.Profile = newResource;
            }

            user.Name = request.Name;
            user.PhoneNumber = request.PhoneNumber;
            user.DateOfBirth = request.DateOfBirth;
            user.Email = request.Email;
            user.UpdatedAt = DateTime.UtcNow;

            await _unitOfWork.Commit();

            ProfileResponse profile = _mapper.Map<ProfileResponse>(user);

            response.Data = profile;
            response.Message = "Perfil actualizado correctamente.";
            return response;
        }

        public async Task<ResultPattern<AddToFriendsResponse>> AddToFriends(AddToFriendsRequest request)
        {
            ResultPattern<AddToFriendsResponse> response = new ResultPattern<AddToFriendsResponse>();
            
            bool userExist = await _userRepository.Exists(x => x.Id == request.FriendId);
            if (!userExist)
            {
                response.StatusCode = 404;
                response.Message = "Usuario no encontrado.";
                response.IsSuccess = false;
                return response;
            }

            bool isFriend = await _userFriendRepository.Exists(x => x.UserId == request.UserId && x.FriendId == request.FriendId);
            if (isFriend)
            {
                response.StatusCode = 409;
                response.Message = "El usuario ya es tu amigo.";
                response.IsSuccess = false;
                return response;
            }

            await _userFriendRepository.Add(new UserFriend
            {
                UserId = request.UserId,
                FriendId = request.FriendId
            });

            await _unitOfWork.Commit();

            response.Message = "Usuario agregado a tu lista de amigos.";
            response.Data = new AddToFriendsResponse 
            {
                FriendId = request.FriendId,
                UserId = request.UserId
            };
            return response;
        }
        public async Task<ResultPattern<AddToFriendsResponse>> DeleteToFriends(AddToFriendsRequest request)
        {
            ResultPattern<AddToFriendsResponse> response = new ResultPattern<AddToFriendsResponse>();

            bool userExist = await _userRepository.Exists(x => x.Id == request.FriendId);
            if (!userExist)
            {
                response.StatusCode = 404;
                response.Message = "Usuario no encontrado.";
                response.IsSuccess = false;
                return response;
            }

            bool isFriend = await _userFriendRepository.Exists(x => x.UserId == request.UserId && x.FriendId == request.FriendId);
            if (!isFriend)
            {
                response.StatusCode = 409;
                response.Message = "El usuario no pertenece a tu lista de amigos.";
                response.IsSuccess = false;
                return response;
            }
            response.Data = new AddToFriendsResponse
            {
                FriendId = request.FriendId,
                UserId = request.UserId
            };

            UserFriend userFriend = await _userFriendRepository.GetFirstOrDefault(x => x.UserId == request.UserId && x.FriendId == request.FriendId);
            await _userFriendRepository.Delete(userFriend);

            await _unitOfWork.Commit();

            response.Message = "Usuario eliminado de tu lista de amigos.";
            
            return response;
        }
    }
}
