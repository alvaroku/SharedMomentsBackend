namespace SharedMomentsBackend.App.Models.DTOs
{
    public class MomentResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public Guid OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? AlbumId { get; set; }
        public string? Album { get; set; }
        public IEnumerable<ResourceResponse> Resources { get; set; } = Enumerable.Empty<ResourceResponse>();
    }
}
