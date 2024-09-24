using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.User;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResultPattern<LoginResponse>> Login(LoginRequest request);
        Task<ResultPattern<UserResponse>> Register(UserRequest request);
        Task<ResultPattern<IEnumerable<UserFriendRequest>>> DataDropDownFriends(DefaultFilterParams filterParams,Guid currentUserId);
        Task<ResultPattern<List<UserFriendRequest>>> DataDropDownNoFriends(DefaultFilterParams filterParams, Guid currentUserId);
        Task<ResultPattern<ProfileResponse>> GetProfile(Guid userId);
        Task<ResultPattern<ProfileResponse>> UpdateProfile(Guid userId, ProfileRequest request);
        Task<ResultPattern<AddToFriendsResponse>> SendFriendRequest(AddToFriendsRequest request);
        Task<ResultPattern<AddToFriendsResponse>> AcceptFriendRequest(AddToFriendsRequest request);
        Task<ResultPattern<AddToFriendsResponse>> DeleteFromFriends(AddToFriendsRequest request);
        Task<ResultPattern<AddToFriendsResponse>> DeleteFriendRequest(AddToFriendsRequest request);
    }
}
