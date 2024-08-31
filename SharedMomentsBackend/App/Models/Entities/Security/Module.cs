namespace SharedMomentsBackend.App.Models.Entities.Security
{
    public class Module:BaseEntity
    {
        public string Name { get; set; }  
        public ICollection<ModuleAction> ModuleActions { get; set; }  
    }
}
