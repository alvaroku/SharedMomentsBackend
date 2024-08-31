namespace SharedMomentsBackend.App.Models.DTOs
{
    public class MomentRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public Guid OwnerId { get; set; }
        public Guid? AlbumId { get; set; }
    }
}
