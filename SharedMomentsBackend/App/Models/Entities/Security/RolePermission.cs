namespace SharedMomentsBackend.App.Models.Entities.Security
{
    public class RolePermission:BaseEntity
    {
        public Guid RoleId { get; set; }
        public Role Role { get; set; } = new Role();

        public Guid PermissionId { get; set; }
        public Permission Permission { get; set; } 
    }
}
