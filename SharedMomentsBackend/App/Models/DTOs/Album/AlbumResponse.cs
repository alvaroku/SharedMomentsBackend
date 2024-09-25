namespace SharedMomentsBackend.App.Models.DTOs.Album
{
    public class AlbumResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string? ProfileUrl { get; set; }
        public IEnumerable<AlbumUserResponse> SharedWith { get; set; } = Enumerable.Empty<AlbumUserResponse>();
    }
}
