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
        public string GetToken(Guid userId, string userName)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, userName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("userId", userId.ToString())
        };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
