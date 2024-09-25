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
        }

    }
}