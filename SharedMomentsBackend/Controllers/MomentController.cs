using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Services.Interfaces;
using System.Security.Claims;
using static System.Net.Mime.MediaTypeNames;

namespace SharedMomentsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MomentController : ControllerBase
    {
        IMomentService _momentService;
        public MomentController(IMomentService momentService)
        {
            _momentService = momentService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get(int pageNumber, int pageSize,string? search,bool? status)
        {
            DefaultFilterParams filters = new DefaultFilterParams { PageNumber = pageNumber, PageSize = pageSize, Search = search, Status = status, };
            ResultPattern<PaginateResponse<MomentResponse>>
                result = await _momentService.GetMoments(filters);
            return StatusCode(result.StatusCode, result);
        }

       
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            ResultPattern<MomentResponse>
               result = await _momentService.GetMoment(id);
            return StatusCode(result.StatusCode, result);
        }

        // POST api/<AlbumController>
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] MomentRequest request, List<IFormFile> resources)
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
            Claim userIdClaim = User.FindFirst("userId");
            request.UserId = Guid.Parse(userIdClaim.Value);
            ResultPattern<MomentResponse> result = await _momentService.CreateMoment(request,Resources);

            return StatusCode(result.StatusCode, result);
        }

        // PUT api/<AlbumController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult>  Put(Guid id, [FromForm] MomentRequest request, List<IFormFile> resources)
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
            Claim userIdClaim = User.FindFirst("userId");
            request.UserId = Guid.Parse(userIdClaim.Value);
            ResultPattern<MomentResponse> result = await _momentService.UpdateMoment(id,request, Resources);

            return StatusCode(result.StatusCode, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            ResultPattern<bool> result = await _momentService.DeleteMoment(id);

            return StatusCode(result.StatusCode, result);
        }
    }
}
