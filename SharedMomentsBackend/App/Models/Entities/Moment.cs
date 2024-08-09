namespace SharedMomentsBackend.App.Models.Entities
{
    public class Moment : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid? AlbumId { get; set; }
        public Album? Album { get; set; }
        public ICollection<MomentResource> MomentResources { get; set; }
    }
}
