using AuthManagerLibrary.App.Definitions;
using AuthManagerLibrary.App.Models;
using AutoMapper;
using EncryptifyLibrary.App.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.DTOs;
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
        public UserService(
            IUserRepository userRepository,
            IMapper mapper,
            IEncryptService encryptService,
            IAuthenticationService authenticationService,
            IRoleRepository roleRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _encryptService = encryptService;
            _authenticationService = authenticationService;
            _roleRepository = roleRepository;
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
    }
}
