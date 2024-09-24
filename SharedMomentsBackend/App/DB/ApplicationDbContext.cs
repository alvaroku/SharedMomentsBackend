using EncryptifyLibrary.App.Interfaces;
using Microsoft.EntityFrameworkCore;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Models.Entities.Security;

namespace SharedMomentsBackend.App.DB
{
    public class ApplicationDbContext : DbContext
    {
        IEncryptService _encryptService;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,IEncryptService encryptService)
           : base(options)
        {
            _encryptService = encryptService;
        }
        public DbSet<Album>Albums { get; set; }
        public DbSet<AlbumUser> AlbumUsers { get; set; }
        public DbSet<Moment> Moments { get; set; }
        public DbSet<MomentResource> MomentResources { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MomentUser> MomentUsers { get; set; }

        public DbSet<UserFriend> UserFriends { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Models.Entities.Security.Action> Actions { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleAction> ModuleActions { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFriend>()
                .HasKey(uf => new { uf.UserId, uf.FriendId }); // Clave compuesta

            modelBuilder.Entity<UserFriend>()
                .HasOne(uf => uf.User)
                .WithMany(u => u.UserFriends)
                .HasForeignKey(uf => uf.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Evitar eliminación en cascada

            modelBuilder.Entity<UserFriend>()
                .HasOne(uf => uf.Friend)
                .WithMany()
                .HasForeignKey(uf => uf.FriendId)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);

            // Definir IDs únicos para roles y usuario
            Guid adminRoleId = Guid.NewGuid();
            Guid userRoleId = Guid.NewGuid();
            Guid adminUserId = Guid.NewGuid();

            // Definir roles
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = adminRoleId, Name = "Admin" },
                new Role { Id = userRoleId, Name = "User" }
            );

            // Definir usuario por defecto
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = adminUserId,
                    Name = "Alvaro Kú",
                    Email = "alvaroku123@gmail.com",
                    PasswordHash = _encryptService.Encrypt("hashed_password"),
                    RoleId = adminRoleId,
                    PhoneNumber = "9919596720",
                    DateOfBirth = new DateTime(2000, 05, 23)
                }
            );

            // Definir módulos
            var modules = new[]
            {
        new Module { Id = Guid.NewGuid(), Name = "Users" },
        new Module { Id = Guid.NewGuid(), Name = "Moments" },
        new Module { Id = Guid.NewGuid(), Name = "Albums" },
        new Module { Id = Guid.NewGuid(), Name = "Resources" }
    };

            modelBuilder.Entity<Module>().HasData(modules);

            // Definir acciones CRUD y ChangeStatus
            var actions = new[]
            {
        new Models.Entities.Security.Action { Id = Guid.NewGuid(), Name = "Create" },
        new Models.Entities.Security.Action { Id = Guid.NewGuid(), Name = "Read" },
        new Models.Entities.Security.Action { Id = Guid.NewGuid(), Name = "Update" },
        new Models.Entities.Security.Action { Id = Guid.NewGuid(), Name = "Delete" },
        new Models.Entities.Security.Action { Id = Guid.NewGuid(), Name = "ChangeStatus" }
    };

            modelBuilder.Entity<Models.Entities.Security.Action>().HasData(actions);

            // Definir relaciones entre módulos y acciones (ModuleAction) usando claves foráneas
            var moduleActions = new List<ModuleAction>();
            foreach (var module in modules)
            {
                foreach (var action in actions)
                {
                    var moduleActionId = Guid.NewGuid();
                    moduleActions.Add(new ModuleAction
                    {
                        Id = moduleActionId,
                        ModuleId = module.Id,
                        ActionId = action.Id
                    });
                }
            }

            modelBuilder.Entity<ModuleAction>().HasData(moduleActions);

            // Definir permisos para cada rol
            var permissions = moduleActions.Select(ma => new Permission
            {
                Id = Guid.NewGuid(),
                ModuleActionId = ma.Id,
            }).ToList();

            modelBuilder.Entity<Permission>().HasData(permissions);

            // Definir relaciones de roles con permisos (RolePermission) usando claves foráneas
            var rolePermissions = new List<RolePermission>();
            foreach (var permission in permissions)
            {
                rolePermissions.Add(new RolePermission
                {
                    Id = Guid.NewGuid(),
                    RoleId = adminRoleId,
                    PermissionId = permission.Id,
                    Role = null
                });

                // Asignar permisos al rol User con restricciones
                var relatedModuleAction = moduleActions.FirstOrDefault(ma => ma.Id == permission.ModuleActionId);
                if (relatedModuleAction != null)
                {
                    if (relatedModuleAction.ModuleId != modules.First(m => m.Name == "Users").Id &&
                        relatedModuleAction.ModuleId != modules.First(m => m.Name == "Resources").Id &&
                        relatedModuleAction.ActionId != actions.First(a => a.Name == "Delete").Id)
                    {
                        rolePermissions.Add(new RolePermission
                        {
                            Id = Guid.NewGuid(),
                            RoleId = userRoleId,
                            PermissionId = permission.Id,
                            Role = null
                        });
                    }
                    else if (relatedModuleAction.ActionId == actions.First(a => a.Name == "ChangeStatus").Id &&
                             (relatedModuleAction.ModuleId == modules.First(m => m.Name == "Users").Id ||
                              relatedModuleAction.ModuleId == modules.First(m => m.Name == "Resources").Id))
                    {
                        rolePermissions.Add(new RolePermission
                        {
                            Id = Guid.NewGuid(),
                            RoleId = userRoleId,
                            PermissionId = permission.Id,
                            Role = null
                        });
                    }
                }
            }

            modelBuilder.Entity<RolePermission>().HasData(rolePermissions);
        }

    }
}