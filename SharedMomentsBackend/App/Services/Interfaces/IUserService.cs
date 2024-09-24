using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.User;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResultPattern<LoginResponse>> Login(LoginRequest request);
        Task<ResultPattern<UserResponse>> Register(UserRequest request);
        Task<ResultPattern<IEnumerable<DataDropdownUser>>> DataDropDownFriends(DefaultFilterParams filterParams,Guid currentUserId);
        Task<ResultPattern<IEnumerable<DataDropdownUser>>> DataDropDownNoFriends(DefaultFilterParams filterParams, Guid currentUserId);
        Task<ResultPattern<ProfileResponse>> GetProfile(Guid userId);
        Task<ResultPattern<ProfileResponse>> UpdateProfile(Guid userId, ProfileRequest request);
        Task<ResultPattern<AddToFriendsResponse>> AddToFriends(AddToFriendsRequest request);
        Task<ResultPattern<AddToFriendsResponse>> DeleteToFriends(AddToFriendsRequest request);
    }
}
