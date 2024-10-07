using Microsoft.EntityFrameworkCore;
using SharedMomentsBackend.App.DB.Respositories.Base.Implementations;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.DTOs.User;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.DB.Respositories.Implementations
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork context) : base(context)
        {
        }
        public async Task<User> Login(LoginRequest loginRequest)
        {
            return await GetFirstOrDefault(x => 
                x.IsActive && x.Email == loginRequest.Email && 
                x.PasswordHash == loginRequest.Password,includeProperties:$"{nameof(User.Profile)}");
        }
    }
}
