using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpGet("DataDropDownFriends")]
        public async Task<IActionResult> DataDropDownFriends(int pageNumber, int pageSize, string? search, bool? status)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);

            DefaultFilterParams request = new DefaultFilterParams { PageNumber = pageNumber, PageSize = pageSize, Search = search, Status = status };
            ResultPattern<IEnumerable<DataDropdownUser>> result = await _userService.DataDropDownFriends(request, OwnerId);
            return StatusCode(result.StatusCode, result);
        }
        [Authorize]
        [HttpGet("DataDropDownNoFriends")]
        public async Task<IActionResult> DataDropDownNoFriends(int pageNumber, int pageSize, string? search, bool? status)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);

            DefaultFilterParams request = new DefaultFilterParams { PageNumber = pageNumber, PageSize = pageSize, Search = search, Status = status };
            ResultPattern<IEnumerable<DataDropdownUser>> result = await _userService.DataDropDownNoFriends(request, OwnerId);
            return StatusCode(result.StatusCode, result);
        }
        [Authorize]
        [HttpGet("Profile")]
        public async Task<IActionResult> GetProfile()
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);

            ResultPattern<ProfileResponse> result = await _userService.GetProfile(OwnerId);
            return StatusCode(result.StatusCode, result);
        }
        [Authorize]
        [HttpPut("Profile")]
        public async Task<IActionResult> UpdateProfile([FromForm] ProfileRequest profile)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);
            ResultPattern<ProfileResponse> result = await _userService.UpdateProfile(OwnerId,profile);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize]
        [HttpPost("AddToFriends")]
        public async Task<IActionResult> AddToFriends(AddToFriendsRequest request)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);
            request.UserId = OwnerId;
            ResultPattern<AddToFriendsResponse> result = await _userService.AddToFriends(request);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize]
        [HttpDelete("DeleteToFriends/{friendId}")]
        public async Task<IActionResult> DeleteToFriends(Guid friendId)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);

            AddToFriendsRequest request = new AddToFriendsRequest { UserId = OwnerId, FriendId = friendId };

            ResultPattern<AddToFriendsResponse> result = await _userService.DeleteToFriends(request);
            return StatusCode(result.StatusCode, result);
        }
    }
}
