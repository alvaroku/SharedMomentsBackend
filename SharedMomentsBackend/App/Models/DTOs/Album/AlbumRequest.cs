namespace SharedMomentsBackend.App.Models.DTOs.Album
{
    public class AlbumRequest
    {
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
