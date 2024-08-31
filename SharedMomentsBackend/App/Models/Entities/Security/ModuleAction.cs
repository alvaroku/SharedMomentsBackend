namespace SharedMomentsBackend.App.Models.Entities.Security
{
    public class ModuleAction:BaseEntity
    {
        public Guid ModuleId { get; set; }
        public Module Module { get; set; }  

        public Guid ActionId { get; set; }
        public Action Action { get; set; } 
    }
}
