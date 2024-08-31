namespace SharedMomentsBackend.App.Models.Entities.Security
{
    public class Permission:BaseEntity
    {
        public Guid ModuleActionId { get; set; }
        public ModuleAction ModuleAction { get; set; }

        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>(); // Relación con roles
    }
}
