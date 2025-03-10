﻿using AuthManagerLibrary.App.Definitions;
using AuthManagerLibrary.App.Models;
using AutoMapper;
using CustomStorageLibrary.App.Interfaces;
using EmailSenderLibrary.App.Interfaces;
using EmailSenderLibrary.App.Models;
using EncryptifyLibrary.App.Interfaces;
using Microsoft.EntityFrameworkCore;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Resource;
using SharedMomentsBackend.App.Models.DTOs.User;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Models.Entities.Security;
using SharedMomentsBackend.App.Services.Interfaces;
using System.Linq;
using System.Linq.Expressions;


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
        IEmailSender _emailSender;
        IConfiguration _configuration;
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
            IUserFriendRepository userFriendRepository,
            IEmailSender emailSender,
            IConfiguration configuration
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
            _emailSender = emailSender;
            _configuration = configuration;
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
            response.Data.ProfilePicture = user.Profile?.Url;
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
        Expression<Func<UserFriend, bool>> GetFilterFriends(Guid currentUserId)
        {
            return x => (x.UserId == currentUserId || x.FriendId == currentUserId) && x.Status.Equals(EFriendRequestStatus.Accepted);
        }
        public async Task<ResultPattern<IEnumerable<UserFriendRequest>>> GetFriendList(DefaultFilterParams filterParams, Guid currentUserId)
        {
            ResultPattern<IEnumerable<UserFriendRequest>> response = new ResultPattern<IEnumerable<UserFriendRequest>>();

            IEnumerable<UserFriend> users = await _userFriendRepository
                .GetAll(filter:GetFilterFriends(currentUserId), null, $"{nameof(UserFriend.Friend)}.{nameof(User.Profile)},{nameof(UserFriend.User)}.{nameof(User.Profile)}");

            response.Data =  users.Select(x => new UserFriendRequest
            {
                Id = x.FriendId,
                Label = (x.UserId == currentUserId) ? x.Friend.Name : x.User.Name,
                ProfileUrl = (x.UserId == currentUserId) ? x.Friend.Profile?.Url : x.User.Profile?.Url,
                Status = x.Status,
                OwnerId = x.UserId
            });
            return response;
        }
        public async Task<ResultPattern<List<UserFriendRequest>>> GetNoFriendList(DefaultFilterParams filterParams, Guid currentUserId)
        {
            ResultPattern<List<UserFriendRequest>> response = new ResultPattern<List<UserFriendRequest>>();

            IQueryable<User> allUsers = _unitOfWork.Context.Users.AsQueryable().Include(x=>x.Profile).Where(x=>x.Id!=currentUserId);

            IQueryable<Guid> friendIds = _unitOfWork.Context.UserFriends
                .Where(x=> (x.UserId == currentUserId || x.FriendId == currentUserId))//usuarios que ya les mandé solicitud|que ya me mandaron|que ya son mis amigos independientemente de si ya me aceptaron o no(existe relación en UserFriends)
                .Select(x => x.UserId == currentUserId ? x.FriendId : x.UserId);//si el userId es igual al currentUserId entonces la solicitud es para el amigo, si no es para el usuario actual

            IQueryable<User> usersNotInFriends = allUsers.Where(x => !friendIds.Contains(x.Id));//usuarios que no les he mandado solicitud(no existe relación en UserFriends)

            IEnumerable<UserFriend> sentReceivedRequestFriend = await _userFriendRepository
                .GetAll(x => (x.UserId == currentUserId || x.FriendId == currentUserId) && x.Status == EFriendRequestStatus.Sent,includeProperties:$"{nameof(UserFriend.Friend)}.{nameof(User.Profile)},{nameof(UserFriend.User)}.{nameof(User.Profile)}");//solicitudes pendientes enviadas y recibidas

            response.Data = new List<UserFriendRequest>();

            response.Data.AddRange( usersNotInFriends.Select(x => new UserFriendRequest
            {
                Id = x.Id,
                Label = x.Name,
                ProfileUrl = x.Profile != null ? x.Profile.Url : null,

            }));
            response.Data.AddRange(sentReceivedRequestFriend.Select(x=> new UserFriendRequest
            {
                Id = x.FriendId,
                Label = (x.UserId == currentUserId)? x.Friend.Name:x.User.Name,
                ProfileUrl = (x.UserId == currentUserId) ? x.Friend.Profile?.Url : x.User.Profile?.Url,
                Status = x.Status,
                OwnerId = x.UserId
            }));
            return response;
        }

        public async Task<ResultPattern<List<DataDropdownUser>>> GetFriendListDropDown(DefaultFilterParams filterParams, Guid currentUserId)
        {
            ResultPattern<List<DataDropdownUser>> response = new ResultPattern<List<DataDropdownUser>>();

            Expression<Func<UserFriend, bool>> filterFriendsFromSentRequest = x=>x.UserId==currentUserId && x.Status.Equals(EFriendRequestStatus.Accepted);//amigos de solicitudes enviadas
            Expression<Func<UserFriend, bool>> filterFriendsFromReceivedRequest = x => x.FriendId == currentUserId && x.Status.Equals(EFriendRequestStatus.Accepted);//amigos de solicitudes enviadas

            IEnumerable<UserFriend> friendsFromSentRequest = await _userFriendRepository
                .GetAll(filter: filterFriendsFromSentRequest, null, $"{nameof(UserFriend.Friend)}.{nameof(User.Profile)}");

            IEnumerable<UserFriend> friendsFromReceivedRequest = await _userFriendRepository
               .GetAll(filter: filterFriendsFromReceivedRequest, null, $"{nameof(UserFriend.User)}.{nameof(User.Profile)}");

            response.Data = new List<DataDropdownUser>();

            response.Data.AddRange(friendsFromSentRequest.Select(x => new DataDropdownUser
            {
                Id = x.FriendId,
                Label = x.Friend.Name ,
                ProfileUrl = x.Friend.Profile?.Url
            }));

            response.Data.AddRange(friendsFromReceivedRequest.Select(x => new DataDropdownUser
            {
                Id = x.UserId,
                Label = x.User.Name,
                ProfileUrl = x.User.Profile?.Url
            }));
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
            bool existUser = await _userRepository.Exists(x => x.Id != userId && x.Email == request.Email);
            if (existUser)
            {
                response.IsSuccess = false;
                response.StatusCode = 409;
                response.Message = "El correo ingresado ya está en uso.";
                return response;
            }
            existUser = await _userRepository.Exists(x => x.Id != userId && x.PhoneNumber == request.PhoneNumber);
            if (existUser)
            {
                response.IsSuccess = false;
                response.StatusCode = 409;
                response.Message = "El teléfono ingresado ya está en uso.";
                return response;
            }
            if (request.Profile is not null)
            {
               if(user.Profile is not null)
                {
                    await _resourceManager.DeleteFile($"{_hostingEnvironment.EnvironmentName}/users", user.Profile.Name, user.Profile.Extension);
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

        public async Task<ResultPattern<AddToFriendsResponse>> SendFriendRequest(AddToFriendsRequest request)
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

            bool isFriend = await _userFriendRepository.Exists(x => x.UserId == request.UserId && x.FriendId == request.FriendId &&  x.Status.Equals(EFriendRequestStatus.Accepted));
            if (isFriend)
            {
                response.StatusCode = 409;
                response.Message = "El usuario ya es tu amigo.";
                response.IsSuccess = false;
                return response;
            }

            isFriend = await _userFriendRepository.Exists(x => ((x.UserId == request.UserId && x.FriendId == request.FriendId) || (x.UserId == request.FriendId && x.FriendId == request.UserId)) && x.Status.Equals(EFriendRequestStatus.Sent));
            if (isFriend)
            {
                response.StatusCode = 409;
                response.Message = "Existe una solicitud pendiente, por favor recarga el navegador para visualizarla.";
                response.IsSuccess = false;
                return response;
            }

            await _userFriendRepository.Add(new UserFriend
            {
                UserId = request.UserId,
                FriendId = request.FriendId,
            });

            await _unitOfWork.Commit();
           
            User friend = await _userRepository.GetFirstOrDefault(x => x.Id == request.FriendId);
            User user = await _userRepository.GetFirstOrDefault(x => x.Id == request.UserId);
            string header = "Solicitud de amistad";
            string dynamicContent = Constants.templateFriendRequest(friend.Name,user.Name,_configuration.GetValue<string>("frontUrl"));
            string htmlBody = string.Format(Constants.htmlTemplate, header, dynamicContent);
            EmailDataRequest emailDataRequest = new EmailDataRequest
            {
                Subject = header,
                Body = htmlBody,
                EmailTo = friend.Email
            };
            await _emailSender.SendEmail(emailDataRequest);

            response.Message = "Solicitud de amistad enviada.";
            response.Data = new AddToFriendsResponse 
            {
                FriendId = request.FriendId,
                UserId = request.UserId,
                Status = EFriendRequestStatus.Sent,  
            };
            return response;
        }

        public async Task<ResultPattern<AddToFriendsResponse>> AcceptFriendRequest(AddToFriendsRequest request)
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

            bool isFriend = await _userFriendRepository.Exists(x => x.UserId == request.UserId && x.FriendId == request.FriendId && x.Status.Equals(EFriendRequestStatus.Sent));
            if (!isFriend)
            {
                response.StatusCode = 409;
                response.Message = "Solicitud no encontrada.";
                response.IsSuccess = false;
                return response;
            }
         
            UserFriend userFriend = await _userFriendRepository
                .GetFirstOrDefault(x => x.UserId == request.UserId && x.FriendId == request.FriendId && x.Status.Equals(EFriendRequestStatus.Sent),
                includeProperties:$"{nameof(UserFriend.Friend)},{nameof(UserFriend.User)}");
            userFriend.Status = EFriendRequestStatus.Accepted;
          
            await _unitOfWork.Commit();

            string header = "Solicitud de amistad aceptada";
            string dynamicContent = Constants.templateAcceptedFriendRequest(userFriend.User.Name,userFriend.Friend.Name , _configuration.GetValue<string>("frontUrl"));
            string htmlBody = string.Format(Constants.htmlTemplate, header, dynamicContent);
            EmailDataRequest emailDataRequest = new EmailDataRequest
            {
                Subject = header,
                Body = htmlBody,
                EmailTo = userFriend.User.Email
            };
            await _emailSender.SendEmail(emailDataRequest);

            response.Message = "Solicitud aceptada.";
            response.Data = new AddToFriendsResponse
            {
                FriendId = userFriend.FriendId,
                UserId = userFriend.UserId,
                Status = userFriend.Status
            };

            return response;
        }
        public async Task<ResultPattern<AddToFriendsResponse>> DeleteFromFriends(AddToFriendsRequest request)
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

            bool isFriend = await _userFriendRepository.Exists(x => x.UserId == request.UserId && x.FriendId == request.FriendId && x.Status.Equals(EFriendRequestStatus.Accepted));
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
                UserId = request.UserId,
                Status = null
            };

            UserFriend userFriend = await _userFriendRepository.GetFirstOrDefault(x => x.UserId == request.UserId && x.FriendId == request.FriendId && x.Status.Equals(EFriendRequestStatus.Accepted));
            
            await _userFriendRepository.Delete(userFriend);

            await _unitOfWork.Commit();

            response.Message = "Usuario eliminado de tu lista de amigos.";
            
            return response;
        }

        public async Task<ResultPattern<AddToFriendsResponse>> DeleteFriendRequest(AddToFriendsRequest request)
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

            bool isFriend = await _userFriendRepository.Exists(x => x.UserId == request.UserId && x.FriendId == request.FriendId && x.Status.Equals(EFriendRequestStatus.Sent));
            if (!isFriend)
            {
                response.StatusCode = 409;
                response.Message = "No se encontró la solicitud de amistad.";
                response.IsSuccess = false;
                return response;
            }
            response.Data = new AddToFriendsResponse
            {
                FriendId = request.FriendId,
                UserId = request.UserId,
                Status = null
            };

            UserFriend userFriend = await _userFriendRepository.GetFirstOrDefault(x => x.UserId == request.UserId && x.FriendId == request.FriendId && x.Status.Equals(EFriendRequestStatus.Sent));
            await _userFriendRepository.Delete(userFriend);

            await _unitOfWork.Commit();

            response.Message = "Solicitud eliminada.";

            return response;
        }

        public async Task<ResultPattern<ChangePasswordResponse>> ChangePassword(ChangePasswordRequest request)
        {
            ResultPattern<ChangePasswordResponse> response = new ResultPattern<ChangePasswordResponse>();   

            bool userExist = await _userRepository.Exists(x => x.Id == request.UserId);
            if (!userExist)
            {
                response.StatusCode = 404;
                response.Message = "Usuario no encontrado.";
                response.IsSuccess = false;
                return response;
            }

            User user = await _userRepository.GetFirstOrDefault(x => x.Id == request.UserId);

            string currentHashedPassword = _encryptService.Encrypt(request.CurrentPassword);

            if (!user.PasswordHash.Equals(currentHashedPassword))
            {
                response.StatusCode = 400;
                response.Message = "Contraseña actual incorrecta.";
                response.IsSuccess = false;
                return response;
            }
            user.PasswordHash = _encryptService.Encrypt(request.NewPassword);
            user.UpdatedAt = DateTime.UtcNow;
            await _unitOfWork.Commit();
            response.Message = "Contraseña actualizada correctamente.";
            return response;
        }

        public async Task<ResultPattern<RecoveryPasswordResponse>> RecoveryPassword(RecoveryPasswordRequest request)
        {
            ResultPattern<RecoveryPasswordResponse> response = new ResultPattern<RecoveryPasswordResponse>();

            bool userExist = await _userRepository.Exists(x => x.Email.ToLower() == request.Email.Trim().ToLower());
            if (!userExist)
            {
                response.StatusCode = 404;
                response.Message = "Usuario no encontrado.";
                response.IsSuccess = false;
                return response;
            }

            User user = await _userRepository.GetFirstOrDefault(x => x.Email.ToLower() == request.Email.Trim().ToLower());
            
            string tempPassword = _encryptService.GenerateRandomString();
            
            user.PasswordHash = _encryptService.Encrypt(tempPassword);
            user.UpdatedAt = DateTime.UtcNow;
            await _unitOfWork.Commit();

            string header = "Recuperación de contraseña";
            string dynamicContent = Constants.templateRecoveryPassword(user.Name, tempPassword, _configuration.GetValue<string>("frontUrl"));
            string htmlBody = string.Format(Constants.htmlTemplate, header, dynamicContent);
            EmailDataRequest emailDataRequest = new EmailDataRequest
            {
                Subject = header,
                Body = htmlBody,
                EmailTo = user.Email
            };
            await _emailSender.SendEmail(emailDataRequest);

            response.Message = "Se ha enviado un correo con la información para acceder nuevamente al sistema, por favor verifica tu bandeja.";
            return response;
        }
    }
}
