using Microsoft.EntityFrameworkCore;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Album>Albums { get; set; }
        public DbSet<AlbumUser> AlbumUsers { get; set; }
        public DbSet<Moment> Moments { get; set; }
        public DbSet<MomentResource> MomentResources { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Role>Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Agrega otras configuraciones aquí

            Guid adminRoleId = Guid.NewGuid();
            Guid userRoleId = Guid.NewGuid();
            Guid adminUserId = Guid.NewGuid();

            modelBuilder.Entity<Role>().HasData(
               new Role { Id = adminRoleId, Name = "Admin" },
               new Role { Id = userRoleId, Name = "User" }
           );

            // Definir usuario por defecto
            modelBuilder.Entity<User>().HasData(
                new User { 
                    Id = adminUserId, 
                    Name = "Alvaro Kú", 
                    Email = "alvaroku123@gmail.com", 
                    PasswordHash =Utils.HashPassword("hashed_password"),
                    RoleId = adminRoleId,
                    PhoneNumber = "9919596720",
                    DateOfBirth = new DateTime(2000, 05, 23)
                }
            );
        }
    }
}