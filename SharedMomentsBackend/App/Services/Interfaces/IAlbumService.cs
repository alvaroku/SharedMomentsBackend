using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.DTOs.Resource;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IMomentService
    {
        Task<ResultPattern<PaginateResponse<MomentResponse>>> GetMoments(FilterOwnerParams filterParams);
        Task<ResultPattern<PaginateResponse<MomentResponse>>> GetSharedWithMe(FilterOwnerParams filterParams);
        Task<ResultPattern<MomentResponse>> CreateMoment(MomentRequest request, List<ResourceRequest> resources);
        Task<ResultPattern<MomentResponse>> GetMoment(Guid id);
        Task<ResultPattern<MomentResponse>> UpdateMoment(Guid id, MomentRequest request, List<ResourceRequest> resources);
        Task<ResultPattern<bool>> DeleteMoment(Guid id);
        Task<ResultPattern<IEnumerable<ShareMomentResponse>>> Share(Guid id, ShareMomentRequest request);
    }
}
