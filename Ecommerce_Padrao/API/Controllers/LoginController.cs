using Default.Return;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.User;
using Service.User.Request;
using Service.User.Response;
using System;
using Transformer.User;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("login")]
        [ProducesResponseType(typeof(DefaultReturn<LoginResponse>), 200)]
        [ProducesResponseType(typeof(DefaultReturn<object>), 400)]
        public IActionResult Login(
            [FromServices] IUserService _userService,
            [FromServices] ITransformerUser _transformer,
            [FromBody] LoginRequest loginRequest
            )
        {
            DefaultReturn<LoginResponse> response = new DefaultReturn<LoginResponse>();
            try
            {
                response.dataReturn = _transformer.ParseUserToLoginResponse(_userService.Authenticate(_transformer.ParseLoginRequestToUser(loginRequest)));
                return StatusCode(200, response);
            }
            catch (Exception ex)
            {
                response.ex = ex;
                return StatusCode(400, response);
            }
        }

    }
}