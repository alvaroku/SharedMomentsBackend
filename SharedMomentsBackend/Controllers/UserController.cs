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
        [HttpGet("GetFriendList")]
        public async Task<IActionResult> GetFriendList(int pageNumber, int pageSize, string? search, bool? status)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);

            DefaultFilterParams request = new DefaultFilterParams { PageNumber = pageNumber, PageSize = pageSize, Search = search, Status = status };
            ResultPattern<IEnumerable<UserFriendRequest>> result = await _userService.GetFriendList(request, OwnerId);
            return StatusCode(result.StatusCode, result);
        }
        [Authorize]
        [HttpGet("GetNoFriendList")]
        public async Task<IActionResult> GetNoFriendList(int pageNumber, int pageSize, string? search, bool? status)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);

            DefaultFilterParams request = new DefaultFilterParams { PageNumber = pageNumber, PageSize = pageSize, Search = search, Status = status };
            ResultPattern<List<UserFriendRequest>> result = await _userService.GetNoFriendList(request, OwnerId);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize]
        [HttpGet("GetFriendListDropDown")]
        public async Task<IActionResult> GetFriendListDropDown(int pageNumber, int pageSize, string? search, bool? status)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);

            DefaultFilterParams request = new DefaultFilterParams { PageNumber = pageNumber, PageSize = pageSize, Search = search, Status = status };
            ResultPattern<List<DataDropdownUser>> result = await _userService.GetFriendListDropDown(request, OwnerId);
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
        [HttpPost("SendFriendRequest")]
        public async Task<IActionResult> SendFriendRequest(AddToFriendsRequest request)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);
            request.UserId = OwnerId;
            ResultPattern<AddToFriendsResponse> result = await _userService.SendFriendRequest(request);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize]
        [HttpPost("AcceptFriendRequest")]
        public async Task<IActionResult> AcceptFriendRequest(AddToFriendsRequest request)
        {
            ResultPattern<AddToFriendsResponse> result = await _userService.AcceptFriendRequest(request);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize]
        [HttpDelete("{ownerId}/DeleteFromFriends/{friendId}")]
        public async Task<IActionResult> DeleteFromFriends(Guid ownerId, Guid friendId)
        {
            AddToFriendsRequest request = new AddToFriendsRequest { UserId = ownerId, FriendId = friendId };
            ResultPattern<AddToFriendsResponse> result = await _userService.DeleteFromFriends(request);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize]
        [HttpDelete("{ownerId}/DeleteFriendRequest/{friendId}")]
        public async Task<IActionResult> DeleteFriendRequest(Guid ownerId,Guid friendId)
        {
            AddToFriendsRequest request = new AddToFriendsRequest { UserId = ownerId, FriendId = friendId };

            ResultPattern<AddToFriendsResponse> result = await _userService.DeleteFriendRequest(request);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize]
        [HttpPut("ChangePassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordRequest request)
        {
            Claim userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Guid OwnerId = Guid.Parse(userIdClaim.Value);
            request.UserId = OwnerId;
            ResultPattern<ChangePasswordResponse> result = await _userService.ChangePassword(request);
            return StatusCode(result.StatusCode, result);
        }

        [HttpPost("RecoveryPassword")]
        public async Task<IActionResult> RecoveryPassword(RecoveryPasswordRequest request)
        {
            ResultPattern<RecoveryPasswordResponse> result = await _userService.RecoveryPassword(request);
            return StatusCode(result.StatusCode, result);
        }
    }
}
