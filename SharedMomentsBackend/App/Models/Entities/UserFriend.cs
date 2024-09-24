namespace SharedMomentsBackend.App.Models.Entities
{
    public class UserFriend
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid FriendId { get; set; }
        public User Friend { get; set; }
        public EFriendRequestStatus Status { get; set; } 
    }
}
