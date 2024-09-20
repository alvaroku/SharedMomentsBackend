using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.DB.Respositories.Interfaces
{
    public interface IMomentRepository:IGenericRepository<Moment>
    {
        Task<PaginateResponse<Moment>> GetMoments(FilterMomentParams filterUser, string includes);
    }
}
