namespace SharedMomentsBackend.App.Models.Entities.Security
{
    public class Action:BaseEntity
    {
        public string Name { get; set; }  
        public ICollection<ModuleAction> ModuleActions { get; set; } 
    }
}
