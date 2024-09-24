using SharedMomentsBackend.App.DB.Respositories.Base.Implementations;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Implementations;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Services.Implementations;
using SharedMomentsBackend.App.Services.Interfaces;

namespace SharedMomentsBackend.App.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // Registrar repositorios
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMomentRepository, MomentRepository>();
            services.AddScoped<IResourceRepository, ResourceRepository>();
            services.AddScoped<IMomentResourceRepository, MomentResourceRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IMomentUserRepository, MomentUserRepository>();
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<IAlbumUserRepository, AlbumUserRepository>();
            services.AddScoped<IUserFriendRepository, UserFriendRepository>();

            // Registrar servicios de negocio
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMomentService, MomentService>();
            services.AddScoped<IResourceService, ResourceService>();
            services.AddScoped<IAlbumService, AlbumService>();
            return services;
        }
    }
}
