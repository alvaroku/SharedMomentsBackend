using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.DTOs.Resource;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IMomentService
    {
        Task<ResultPattern<PaginateResponse<MomentResponse>>> GetMoments(FilterMomentParams filterParams);
        Task<ResultPattern<PaginateResponse<MomentResponse>>> GetSharedWithMe(FilterMomentParams filterParams);
        Task<ResultPattern<MomentResponse>> CreateMoment(MomentRequest request, List<ResourceRequest> resources);
        Task<ResultPattern<MomentResponse>> GetMoment(Guid id);
        Task<ResultPattern<MomentResponse>> UpdateMoment(Guid id, MomentRequest request, List<ResourceRequest> resources);
        Task<ResultPattern<bool>> DeleteMoment(Guid id);
        Task<ResultPattern<IEnumerable<ShareMomentResponse>>> Share(Guid id, ShareMomentRequest request);
        Task<ResultPattern<bool>> DeleteShare(Guid userId,Guid momentId);
        Task<ResultPattern<AddToAlbumResponse>> AddToAlbum(AddToAlbumRequest request);
    }
}
