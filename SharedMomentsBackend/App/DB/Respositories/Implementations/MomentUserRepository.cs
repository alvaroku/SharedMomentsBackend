using SharedMomentsBackend.App.DB.Respositories.Base.Implementations;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;
using System.Linq.Expressions;
using SharedMomentsBackend.App.Extensions;

namespace SharedMomentsBackend.App.DB.Respositories.Implementations
{
    public class MomentUserRepository : GenericRepository<MomentUser>, IMomentUserRepository
    {
        public MomentUserRepository(IUnitOfWork context) : base(context)
        {

        }
        public async Task<PaginateResponse<MomentUser>> GetSharedWithMe(FilterMomentParams filterUser, string includes)
        {
            return await GetPaginate(GetExpression(filterUser), filterUser, includes);
        }
        private Expression<Func<MomentUser, bool>> GetExpression(FilterMomentParams defaultFilter)
        {
            Expression<Func<MomentUser, bool>> filter = x => x.UserId.Equals(defaultFilter.OwnerId);

            if (!string.IsNullOrWhiteSpace(defaultFilter.Search))
            {
                filter = filter.And(x => x.Moment.Title.ToLower().Contains(defaultFilter.Search.ToLower()));
            }
            if (defaultFilter.Status is not null)
            {
                filter = filter.And(x => x.Moment.IsActive == defaultFilter.Status);
            }
            if (defaultFilter.HasAlbum.HasValue)
            {
                filter = filter.And(x => (defaultFilter.HasAlbum.Value) ? x.Moment.AlbumId.HasValue : !x.Moment.AlbumId.HasValue);
            }
            if (defaultFilter.AlbumId is not null)
            {
                filter = filter.And(x => x.Moment.AlbumId == defaultFilter.AlbumId);
            }
            return filter;
        }
    }
}
