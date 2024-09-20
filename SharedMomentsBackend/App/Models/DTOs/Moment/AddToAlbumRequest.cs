namespace SharedMomentsBackend.App.Models.DTOs.Moment
{
    public class AddToAlbumRequest
    {
        public Guid MomentId { get; set; }
        public Guid? AlbumId { get; set; }
        public Guid OwnerId { get; set; }
    }
}
