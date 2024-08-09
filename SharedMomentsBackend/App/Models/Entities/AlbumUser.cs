namespace SharedMomentsBackend.App.Models.Entities
{
    public class AlbumUser:BaseEntity
    {
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
