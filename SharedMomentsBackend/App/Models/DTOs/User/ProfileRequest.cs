namespace SharedMomentsBackend.App.Models.DTOs.User
{
    public class ProfileRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IFormFile? Profile { get; set; }
    }
}
