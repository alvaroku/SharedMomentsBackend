namespace SharedMomentsBackend.App.Models.DTOs.User
{
    public class AddToFriendsResponse
    {
        public Guid UserId { get; set; }
        public Guid FriendId { get; set; }
    }
}
