using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Album;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Services.Implementations;
using SharedMomentsBackend.App.Services.Interfaces;
using System.Security.Claims;

namespace SharedMomentsBackend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class AlbumController : ControllerBase
    {
        IAlbumService _albumService;
        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int pageNumber, int pageSize, string? search, bool? status)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid userId = Guid.Parse(userIdClaim.Value);
            FilterOwnerParams filters = new FilterOwnerParams { OwnerId = userId, PageNumber = pageNumber, PageSize = pageSize, Search = search, Status = status, };
            ResultPattern<PaginateResponse<AlbumResponse>>
                result = await _albumService.GetAlbums(filters);
            return StatusCode(result.StatusCode, result);
        }
        [HttpGet("GetSharedWithMe")]
        public async Task<IActionResult> GetSharedWithMe(int pageNumber, int pageSize, string? search, bool? status)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid userId = Guid.Parse(userIdClaim.Value);
            FilterOwnerParams filters = new FilterOwnerParams { OwnerId = userId, PageNumber = pageNumber, PageSize = pageSize, Search = search, Status = status, };
            ResultPattern<PaginateResponse<AlbumResponse>>
                result = await _albumService.GetSharedWithMe(filters);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            ResultPattern<AlbumResponse>
               result = await _albumService.GetAlbum(id);
            return StatusCode(result.StatusCode, result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AlbumRequest request)
        {
            try
            {

                Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
                request.OwnerId = Guid.Parse(userIdClaim.Value);
                ResultPattern<AlbumResponse> result = await _albumService.CreateAlbum(request);

                return StatusCode(result.StatusCode, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResultPattern<MomentResponse>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    StatusCode = 500
                });
            }
        }

        // PUT api/<AlbumController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, AlbumRequest request)
        {

            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            request.OwnerId = Guid.Parse(userIdClaim.Value);
            ResultPattern<AlbumResponse> result = await _albumService.UpdateAlbum(id, request);

            return StatusCode(result.StatusCode, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            ResultPattern<bool> result = await _albumService.DeleteAlbum(id);

            return StatusCode(result.StatusCode, result);
        }

        [HttpPost("{id}/Share")]
        public async Task<IActionResult> Share(Guid id, ShareAlbumRequest request)
        {
            ResultPattern<IEnumerable<ShareAlbumResponse>> result = await _albumService.Share(id, request);

            return StatusCode(result.StatusCode, result);
        }

        [HttpDelete("{albumId}/DeleteShare/{userId}")]
        public async Task<IActionResult> DeleteShare(Guid userId, Guid albumId)
        {
            ResultPattern<bool> result = await _albumService.DeleteShare(userId, albumId);

            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("GetMyAlbums")]
        public async Task<IActionResult> GetMyAlbums(int pageNumber, int pageSize, string? search, bool? status)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);

            DefaultFilterParams request = new DefaultFilterParams { PageNumber = pageNumber, PageSize = pageSize, Search = search, Status = status };
            ResultPattern<IEnumerable<DataDropDown>> result = await _albumService.GetMyAlbums(request, OwnerId);
            return StatusCode(result.StatusCode, result);
        }
    }
}
