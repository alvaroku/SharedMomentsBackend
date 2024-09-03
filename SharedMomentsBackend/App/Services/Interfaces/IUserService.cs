using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.User;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResultPattern<LoginResponse>> Login(LoginRequest request);
        Task<ResultPattern<UserResponse>> Register(UserRequest request);
        Task<ResultPattern<IEnumerable<DataDropDown>>> DataDropDownForShareMoment(DefaultFilterParams filterParams,Guid ownerId);
    }
}
