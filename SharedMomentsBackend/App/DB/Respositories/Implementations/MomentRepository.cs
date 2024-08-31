using SharedMomentsBackend.App.DB.Respositories.Base.Implementations;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Extensions;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;
using System.Linq.Expressions;

namespace SharedMomentsBackend.App.DB.Respositories.Implementations
{
    public class MomentRepository : GenericRepository<Moment>, IMomentRepository
    {
        public MomentRepository(IUnitOfWork context) : base(context)
        {
        }

        public async Task<PaginateResponse<Moment>> GetMoments(FilterUserParams filterUser,string includes)
        {
            return await GetPaginate(GetExpression(filterUser),filterUser, includes);
        }
        private Expression<Func<Moment, bool>> GetExpression(FilterUserParams defaultFilter)
        {
            Expression<Func<Moment, bool>> filter = x => x.OwnerId.Equals(defaultFilter.OwnerId);

            if (!string.IsNullOrWhiteSpace(defaultFilter.Search))
            {
                filter = filter.And(x => x.Title.ToLower().Contains(defaultFilter.Search.ToLower()));
            }
            if (defaultFilter.Status is not null)
            {
                filter = filter.And(x => x.IsActive == defaultFilter.Status);
            }
            return filter;
        }
    }
}
