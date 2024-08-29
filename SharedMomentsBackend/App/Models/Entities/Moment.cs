namespace SharedMomentsBackend.App.Models.Entities
{
    public class Moment : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public Guid OwnerId { get; set; }
        public User Owner { get; set; }

        public Guid? AlbumId { get; set; }
        public Album? Album { get; set; }
        public ICollection<MomentResource> MomentResources { get; set; }
        public ICollection<MomentUser> MomentUsers { get; set; }
    }
}
