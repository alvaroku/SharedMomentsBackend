namespace SharedMomentsBackend.App.Models.Entities
{
    public class Resource : BaseEntity
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Url { get; set; }

        public ICollection<MomentResource> MomentResources { get; set; }
    }
}
