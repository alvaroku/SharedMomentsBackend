﻿using SharedMomentsBackend.App.DB.Respositories.Base.Implementations;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;
using System.Linq.Expressions;
using SharedMomentsBackend.App.Extensions;

namespace SharedMomentsBackend.App.DB.Respositories.Implementations
{
    public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(IUnitOfWork context) : base(context)
        {
        }
        public async Task<PaginateResponse<Album>> GetAlbums(FilterOwnerParams filterUser, string includes)
        {
            return await GetPaginate(GetExpression(filterUser), filterUser, includes);
        }
        private Expression<Func<Album, bool>> GetExpression(FilterOwnerParams defaultFilter)
        {
            Expression<Func<Album, bool>> filter = x => x.OwnerId.Equals(defaultFilter.OwnerId);

            if (!string.IsNullOrWhiteSpace(defaultFilter.Search))
            {
                filter = filter.And(x => x.Name.ToLower().Contains(defaultFilter.Search.ToLower()));
            }
            if (defaultFilter.Status is not null)
            {
                filter = filter.And(x => x.IsActive == defaultFilter.Status);
            }
            return filter;
        }
    }
}
