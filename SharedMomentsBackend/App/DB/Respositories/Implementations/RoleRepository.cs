using SharedMomentsBackend.App.DB.Respositories.Base.Implementations;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.Entities.Security;

namespace SharedMomentsBackend.App.DB.Respositories.Implementations
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
