namespace SharedMomentsBackend.App.Models.Entities
{
    public class Resource : BaseEntity
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public ulong Size { get; set; }
        public string Path { get; set; }
        public ICollection<MomentResource> MomentResources { get; set; }
    }
}
