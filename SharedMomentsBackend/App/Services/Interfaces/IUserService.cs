using SharedMomentsBackend.App.Models.DTOs;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResultPattern<LoginResponse>> Login(LoginRequest request);
        Task<ResultPattern<UserResponse>> Register(UserRequest request);
    }
}
