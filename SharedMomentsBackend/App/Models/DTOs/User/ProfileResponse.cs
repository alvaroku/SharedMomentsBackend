using SharedMomentsBackend.App.Models.DTOs.Resource;

namespace SharedMomentsBackend.App.Models.DTOs.User
{
    public record ProfileResponse
    {
        public string Name { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
        public DateTime DateOfBirth { get; init; }
        public ResourceResponse? Profile { get; init; }
    }
}
