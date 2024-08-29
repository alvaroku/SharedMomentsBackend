using AuthManagerLibrary.App.Definitions;
using AuthManagerLibrary.App.Models;
using AutoMapper;
using EncryptifyLibrary.App.Interfaces;
using Microsoft.EntityFrameworkCore;
using SharedMomentsBackend.App.DB;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Services.Interfaces;

namespace SharedMomentsBackend.App.Services.Implementations
{
    public class UserService : IUserService
    {
        IConfiguration _configuration;
        ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private IEncryptService _encryptService;
        private IAuthenticationService _authenticationService;
        public UserService(
            ApplicationDbContext dbContext,
            IConfiguration configuration,
            IMapper mapper,
            IEncryptService encryptService,
            IAuthenticationService authenticationService)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _mapper = mapper;
            _encryptService = encryptService;
            _authenticationService = authenticationService;
        }
        public async Task<ResultPattern<LoginResponse>> Login(LoginRequest request)
        {
            ResultPattern<LoginResponse> response = new ResultPattern<LoginResponse>();
            request.Password = _encryptService.Encrypt(request.Password);
            bool existUser = await _dbContext.Users.AnyAsync(x => x.Email.Equals(request.Email) && x.PasswordHash.Equals(request.Password));
            if (!existUser)
            {
                response.Message = "Correo o contraseña incorrectos.";
                response.IsSuccess = false;
                response.StatusCode = 401;
                return response;
            }
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Email.Equals(request.Email) && x.PasswordHash.Equals(request.Password));
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

            if (await _dbContext.Users.AnyAsync(x => x.Email == request.Email))
            {
                response.Message = "El correo ingresado ya está en uso.";
                response.StatusCode = 409; // Código de estado 409 Conflict
                response.IsSuccess = false;
                return response;
            }

            if (await _dbContext.Users.AnyAsync(x => x.PhoneNumber == request.PhoneNumber))
            {
                response.Message = "El teléfono ingresado ya está en uso.";
                response.StatusCode = 409; // Código de estado 409 Conflict
                response.IsSuccess = false;
                return response;
            }

            request.PasswordHash = _encryptService.Encrypt(request.PasswordHash);
            if (!request.RoleId.HasValue)
            {
                request.RoleId = await _dbContext.Roles.Where(x => x.Name.Equals("User")).Select(x => x.Id).FirstOrDefaultAsync();
            }
            User user = _mapper.Map<User>(request);
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
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
