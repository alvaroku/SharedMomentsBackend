using Microsoft.AspNetCore.Mvc;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.User;
using SharedMomentsBackend.App.Services.Interfaces;
using System.Security.Claims;

namespace SharedMomentsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            ResultPattern<LoginResponse> result = await _userService.Login(request);
            return StatusCode(result.StatusCode, result);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRequest request)
        {
            ResultPattern<UserResponse> result = await _userService.Register(request);
            return StatusCode(result.StatusCode, result);
        }
        [HttpGet("DataDropDownForShareMoment")]
        public async Task<IActionResult> DataDropDownForShareMoment(int pageNumber, int pageSize, string? search, bool? status)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);

            DefaultFilterParams request = new DefaultFilterParams { PageNumber = pageNumber, PageSize = pageSize, Search = search, Status = status };
            ResultPattern<IEnumerable<DataDropDown>> result = await _userService.DataDropDownForShareMoment(request, OwnerId);
            return StatusCode(result.StatusCode, result);
        }
    }
}
