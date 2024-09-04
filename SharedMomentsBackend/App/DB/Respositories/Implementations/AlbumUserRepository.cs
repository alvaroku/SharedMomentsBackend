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
    public class AlbumUserRepository : GenericRepository<AlbumUser>, IAlbumUserRepository
    {
        public AlbumUserRepository(IUnitOfWork context) : base(context)
        {

        }
        public async Task<PaginateResponse<AlbumUser>> GetSharedWithMe(FilterOwnerParams filterUser, string includes)
        {
            return await GetPaginate(GetExpression(filterUser), filterUser, includes);
        }
        private Expression<Func<AlbumUser, bool>> GetExpression(FilterOwnerParams defaultFilter)
        {
            Expression<Func<AlbumUser, bool>> filter = x => x.UserId.Equals(defaultFilter.OwnerId);

            if (!string.IsNullOrWhiteSpace(defaultFilter.Search))
            {
                filter = filter.And(x => x.Album.Name.ToLower().Contains(defaultFilter.Search.ToLower()));
            }
            if (defaultFilter.Status is not null)
            {
                filter = filter.And(x => x.Album.IsActive == defaultFilter.Status);
            }
            return filter;
        }
    }
}
