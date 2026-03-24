using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrymAPI.Models.Request;
using PrymAPI.Services;

namespace PrymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var isValid = _authService.ValidateUser(request.Username, request.Password);

            if (!isValid)
                return Unauthorized("Invalid credentials");

            return Ok("Login successful");
        }
    }
}
