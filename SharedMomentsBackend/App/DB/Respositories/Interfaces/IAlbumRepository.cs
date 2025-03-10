﻿using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.DB.Respositories.Interfaces
{
    public interface IAlbumRepository : IGenericRepository<Album>
    {
        Task<PaginateResponse<Album>> GetAlbums(FilterOwnerParams filterUser, string includes);
    }
}
