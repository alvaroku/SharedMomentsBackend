using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.User;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResultPattern<LoginResponse>> Login(LoginRequest request);
        Task<ResultPattern<UserResponse>> Register(UserRequest request);
        Task<ResultPattern<IEnumerable<UserFriendRequest>>> GetFriendList(DefaultFilterParams filterParams,Guid currentUserId);
        Task<ResultPattern<List<UserFriendRequest>>> GetNoFriendList(DefaultFilterParams filterParams, Guid currentUserId);
        Task<ResultPattern<List<DataDropdownUser>>> GetFriendListDropDown(DefaultFilterParams filterParams, Guid currentUserId);
        Task<ResultPattern<ProfileResponse>> GetProfile(Guid userId);
        Task<ResultPattern<ProfileResponse>> UpdateProfile(Guid userId, ProfileRequest request);
        Task<ResultPattern<AddToFriendsResponse>> SendFriendRequest(AddToFriendsRequest request);
        Task<ResultPattern<AddToFriendsResponse>> AcceptFriendRequest(AddToFriendsRequest request);
        Task<ResultPattern<AddToFriendsResponse>> DeleteFromFriends(AddToFriendsRequest request);
        Task<ResultPattern<AddToFriendsResponse>> DeleteFriendRequest(AddToFriendsRequest request);
        Task<ResultPattern<ChangePasswordResponse>> ChangePassword(ChangePasswordRequest request);
        Task<ResultPattern<RecoveryPasswordResponse>> RecoveryPassword(RecoveryPasswordRequest request);
    }
}
