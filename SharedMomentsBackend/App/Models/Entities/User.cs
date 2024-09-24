using SharedMomentsBackend.App.Models.Entities.Security;

namespace SharedMomentsBackend.App.Models.Entities
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid? ProfileId { get; set; }
        public Resource? Profile { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<AlbumUser> AlbumUsers { get; set; }
        public ICollection<MomentUser> MomentUsers { get; set; }
        public ICollection<UserFriend> UserFriends { get; set; }
    }
}
