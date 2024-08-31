﻿namespace SharedMomentsBackend.App.Models.Entities.Security
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; } 
    }
}
