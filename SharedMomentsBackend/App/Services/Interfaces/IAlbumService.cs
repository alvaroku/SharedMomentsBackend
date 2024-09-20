using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Album;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.DTOs.Resource;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IAlbumService
    {
        Task<ResultPattern<PaginateResponse<AlbumResponse>>> GetAlbums(FilterOwnerParams filterParams);
        Task<ResultPattern<PaginateResponse<AlbumResponse>>> GetSharedWithMe(FilterOwnerParams filterParams);
        Task<ResultPattern<AlbumResponse>> CreateAlbum(AlbumRequest request);
        Task<ResultPattern<AlbumResponse>> GetAlbum(Guid id);
        Task<ResultPattern<AlbumResponse>> UpdateAlbum(Guid id, AlbumRequest request);
        Task<ResultPattern<bool>> DeleteAlbum(Guid id);
        Task<ResultPattern<IEnumerable<ShareAlbumResponse>>> Share(Guid id, ShareAlbumRequest request);
        Task<ResultPattern<bool>> DeleteShare(Guid userId, Guid albumId);
        Task<ResultPattern<IEnumerable<DataDropDown>>> GetMyAlbums(DefaultFilterParams filterParams, Guid ownerId);
    }
}
