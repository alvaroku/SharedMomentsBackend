using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Album;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.DTOs.Resource;
using SharedMomentsBackend.App.Services.Implementations;
using SharedMomentsBackend.App.Services.Interfaces;
using System.Security.Claims;

namespace SharedMomentsBackend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class MomentController : ControllerBase
    {
        IMomentService _momentService;
        public MomentController(IMomentService momentService)
        {
            _momentService = momentService;
        }

        [HttpGet("GetMoments")]
        public async Task<IActionResult> Get(int pageNumber, int pageSize, string? search, bool? status,bool? hasAlbum,Guid? albumId,Guid? ownerId)
        {
           
            FilterMomentParams filters = new FilterMomentParams 
            { 
                PageNumber = pageNumber, 
                PageSize = pageSize, 
                Search = search, 
                Status = status,
                HasAlbum = hasAlbum,
                AlbumId = albumId
            };
            if (!albumId.HasValue)
            {
                if (!ownerId.HasValue)
                {
                    Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
                    Guid userId = Guid.Parse(userIdClaim.Value);
                    filters.OwnerId = userId;
                }
                else
                {
                    filters.OwnerId = ownerId.Value;
                }
            }
            else
            {
                filters.OwnerId = null;
            }
            ResultPattern<PaginateResponse<MomentResponse>>
                result = await _momentService.GetMoments(filters);
            return StatusCode(result.StatusCode, result);
        }
        [HttpGet("GetSharedWithMe")]
        public async Task<IActionResult> GetSharedWithMe(int pageNumber, int pageSize, string? search, bool? status)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid userId = Guid.Parse(userIdClaim.Value);
            FilterMomentParams filters = new FilterMomentParams 
            { 
                OwnerId = userId, 
                PageNumber = pageNumber, 
                PageSize = pageSize, 
                Search = search, 
                Status = status,
            };
            ResultPattern<PaginateResponse<MomentResponse>>
                result = await _momentService.GetSharedWithMe(filters);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            ResultPattern<MomentResponse>
               result = await _momentService.GetMoment(id);
            return StatusCode(result.StatusCode, result);
        }

        [HttpPost]
        [RequestFormLimits(ValueCountLimit = int.MaxValue, MultipartBodyLengthLimit = long.MaxValue)]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> Post([FromForm] MomentRequest request, List<IFormFile> resources)
        {
            try
            {
                List<ResourceRequest> Resources = new List<ResourceRequest>();

                if (resources is not null)
                {
                    IEnumerable<Task<ResourceRequest>> tasks = resources.Select(async image =>
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        await image.CopyToAsync(memoryStream);
                        memoryStream.Seek(0, SeekOrigin.Begin);
                        return new ResourceRequest
                        {
                            Stream = memoryStream,
                            ContentType = image.ContentType,
                            Extension = Path.GetExtension(image.FileName)
                        };
                    });

                    ResourceRequest[] fileParamsArray = await Task.WhenAll(tasks);

                    Resources.AddRange(fileParamsArray);
                }
                Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
                request.OwnerId = Guid.Parse(userIdClaim.Value);
                ResultPattern<MomentResponse> result = await _momentService.CreateMoment(request, Resources);

                return StatusCode(result.StatusCode, result);
            }catch(Exception ex)
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
        [RequestFormLimits(ValueCountLimit = int.MaxValue, MultipartBodyLengthLimit = long.MaxValue)]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> Put(Guid id, [FromForm] MomentRequest request, List<IFormFile> resources)
        {
            List<ResourceRequest> Resources = new List<ResourceRequest>();

            if (resources is not null)
            {
                IEnumerable<Task<ResourceRequest>> tasks = resources.Select(async image =>
                {
                    MemoryStream memoryStream = new MemoryStream();
                    await image.CopyToAsync(memoryStream);
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    return new ResourceRequest
                    {
                        Stream = memoryStream,
                        ContentType = image.ContentType,
                        Extension = Path.GetExtension(image.FileName)
                    };
                });

                ResourceRequest[] fileParamsArray = await Task.WhenAll(tasks);

                Resources.AddRange(fileParamsArray);
            }
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            request.OwnerId = Guid.Parse(userIdClaim.Value);
            ResultPattern<MomentResponse> result = await _momentService.UpdateMoment(id, request, Resources);

            return StatusCode(result.StatusCode, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            ResultPattern<bool> result = await _momentService.DeleteMoment(id);

            return StatusCode(result.StatusCode, result);
        }

        [HttpPost("{id}/Share")]
        public async Task<IActionResult> Share(Guid id, ShareMomentRequest request)
        {
            ResultPattern<IEnumerable<ShareMomentResponse>> result = await _momentService.Share(id,request);

            return StatusCode(result.StatusCode, result);
        }

        [HttpDelete("{momentId}/DeleteShare/{userId}")]
        public async Task<IActionResult> DeleteShare(Guid userId, Guid momentId)
        {
            ResultPattern<bool> result = await _momentService.DeleteShare(userId, momentId);

            return StatusCode(result.StatusCode, result);
        }

        [HttpPost("AddToAlbum")]
        public async Task<IActionResult> AddToAlbum(AddToAlbumRequest request)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid userId = Guid.Parse(userIdClaim.Value);
            request.OwnerId = userId;
            ResultPattern<AddToAlbumResponse>
                result = await _momentService.AddToAlbum(request);
            return StatusCode(result.StatusCode, result);
        }
    }
}
