using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharedMomentsBackend.App.DB;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SharedMomentsBackend.App.Services.Implementations
{
    public class UserService : IUserService
    {
        IConfiguration _configuration;
        ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public UserService(ApplicationDbContext dbContext,IConfiguration configuration, IMapper mapper) 
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _mapper = mapper;
        }
        public async Task<ResultPattern<LoginResponse>> Login(LoginRequest  request)
        {
            ResultPattern<LoginResponse> response = new ResultPattern<LoginResponse>();
            request.Password = Utils.HashPassword(request.Password);
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
            response.Data.Token = GetToken(user.Id, user.Email);    
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

            request.PasswordHash = Utils.HashPassword(request.PasswordHash);
            if (!request.RoleId.HasValue)
            {
                request.RoleId = await _dbContext.Roles.Where(x => x.Name.Equals("User")).Select(x => x.Id).FirstOrDefaultAsync();
            }
            User user = _mapper.Map<User>(request);
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            response.Data = _mapper.Map<UserResponse>(user);
            response.Message = "Usuario registrado correctamente.";
            response.Data.Token = GetToken(user.Id, user.Email);
            return response;
        }

        public string GetToken(Guid userId, string userName)
        {
            string issuer = _configuration["Jwt:Issuer"];
            string audience = _configuration["Jwt:Audience"];
            byte[] key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
            SigningCredentials signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature
                                );
            ClaimsIdentity subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim(ClaimTypes.Name, userName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, userName)
            });

            DateTime expires = DateTime.UtcNow.AddHours(-6).AddHours(8);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = subject,
                Expires = expires,
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = signingCredentials
            };
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            string jwtToken = tokenHandler.WriteToken(token);
            return jwtToken;
        }
    }
}
