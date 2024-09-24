namespace SharedMomentsBackend.App.Models.DTOs.User
{
    public class AddToFriendsRequest
    {
        public Guid UserId { get; set; }
        public Guid FriendId { get; set; }
    }
}
