namespace SharedMomentsBackend.App.Models.DTOs.User
{
    public class UserFriendRequest:DataDropdownUser
    {
        public EFriendRequestStatus? Status { get; set; }
        public Guid? OwnerId { get; set; }
    }
}
