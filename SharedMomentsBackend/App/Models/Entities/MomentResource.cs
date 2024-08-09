namespace SharedMomentsBackend.App.Models.Entities
{
    public class MomentResource
    {
        public Guid Id { get; set; }
        public Guid ResourceId { get; set; }
        public Resource Resource { get; set; }

        public Guid MomentId { get; set; }
        public Moment Moment { get; set; }
    }
}
