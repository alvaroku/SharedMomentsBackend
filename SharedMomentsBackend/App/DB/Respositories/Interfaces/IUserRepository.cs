﻿using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.DB.Respositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> Login(LoginRequest loginRequest);
    }
}
