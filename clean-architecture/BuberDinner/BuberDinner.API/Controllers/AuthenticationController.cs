using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BuberDinner.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService) 
        { 
            _authenticationService = authenticationService;
        }

        [HttpPost("regiter")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var authenticationResult = await this._authenticationService.Register(request.FirstName, request.LastName, request.Email);

            var result = new AuthenticationResponse
            (
                authenticationResult.Id,
                authenticationResult.FirstName,
                authenticationResult.LastName,
                authenticationResult.AccessToken,
                authenticationResult.Email
            );

            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            return Ok(request);
        }
    }
}
