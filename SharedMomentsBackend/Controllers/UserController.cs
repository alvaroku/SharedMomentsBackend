using Microsoft.AspNetCore.Mvc;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Services.Interfaces;

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
    }
}
