using Microsoft.AspNetCore.Mvc;
using SharedMomentsBackend.App.Models.DTOs;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IMomentService
    {
        Task<ResultPattern<PaginateResponse<MomentResponse>>> GetMoments(DefaultFilterParams filterParams);
        Task<ResultPattern<MomentResponse>> CreateMoment( MomentRequest request, List<ResourceRequest> resources);
        Task<ResultPattern<MomentResponse>> GetMoment(Guid id);
        Task<ResultPattern<MomentResponse>> UpdateMoment(Guid id,MomentRequest request, List<ResourceRequest> resources);
        Task<ResultPattern<bool>> DeleteMoment(Guid id);
    }
}
