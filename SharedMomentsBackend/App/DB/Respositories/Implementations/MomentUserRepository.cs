using SharedMomentsBackend.App.DB.Respositories.Base.Implementations;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.DB.Respositories.Implementations
{
    public class MomentUserRepository : GenericRepository<MomentUser>, IMomentUserRepository
    {
        public MomentUserRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
