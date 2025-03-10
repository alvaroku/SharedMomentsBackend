﻿using SharedMomentsBackend.App.DB.Respositories.Base.Implementations;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Extensions;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.Entities;
using System.Linq.Expressions;

namespace SharedMomentsBackend.App.DB.Respositories.Implementations
{
    public class MomentRepository : GenericRepository<Moment>, IMomentRepository
    {
        public MomentRepository(IUnitOfWork context) : base(context)
        {
        }

        public async Task<PaginateResponse<Moment>> GetMoments(FilterMomentParams filterUser, string includes)
        { 
            return await GetPaginate(GetExpression(filterUser), filterUser, includes);
        }
        private Expression<Func<Moment, bool>> GetExpression(FilterMomentParams defaultFilter)
        {
            Expression<Func<Moment, bool>> filter = x =>defaultFilter.OwnerId.HasValue? x.OwnerId.Equals(defaultFilter.OwnerId.Value):true;

            if (!string.IsNullOrWhiteSpace(defaultFilter.Search))
            {
                filter = filter.And(x => x.Title.ToLower().Contains(defaultFilter.Search.ToLower()));
            }
            if (defaultFilter.Status is not null)
            {
                filter = filter.And(x => x.IsActive == defaultFilter.Status);
            }
            if (defaultFilter.HasAlbum.HasValue)
            {
                filter = filter.And(x => (defaultFilter.HasAlbum.Value)?x.AlbumId.HasValue:!x.AlbumId.HasValue);
            }
            if (defaultFilter.AlbumId is not null)
            {
                filter = filter.And(x => x.AlbumId == defaultFilter.AlbumId);
            }
            return filter;
        }
    }
}
