using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.Models.DTOs
{
    public class UserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid? RoleId { get; set; }
    }
}
