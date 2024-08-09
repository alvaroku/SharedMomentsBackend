using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.Models.DTOs
{
    public class MomentResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public Guid UserId { get; set; }
        public string User { get; set; }

        public Guid? AlbumId { get; set; }
        public string? Album { get; set; }
        public IEnumerable<ResourceResponse> Resources { get; set; }
    }
}
