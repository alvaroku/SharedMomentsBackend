namespace SharedMomentsBackend.App.Models.Entities
{
    public class Album:BaseEntity
    {
        public Guid OwnerId { get; set; }
        public User Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Moment> Moments { get; set; }
        public ICollection<AlbumUser> AlbumUsers { get; set; }
    }
}
