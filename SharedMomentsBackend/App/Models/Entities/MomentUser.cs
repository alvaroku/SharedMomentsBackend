namespace SharedMomentsBackend.App.Models.Entities
{
    public class MomentUser: BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid MomentId { get; set; }
        public Moment Moment { get; set; }
    }
}
