using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Default.Return;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.User;
using Service.User;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        #region Properties
        private IUserService _userService;
        #endregion

        #region Constructor
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        [AllowAnonymous]
        [HttpPost("login")]
        [ProducesResponseType(typeof(DefaultReturn<User>), 200)]
        [ProducesResponseType(typeof(DefaultReturn<object>), 400)]
        public IActionResult Login(string username, string password)
        {
            DefaultReturn<User> response = new DefaultReturn<User>();
            try
            {
                response.dataReturn = _userService.Authenticate(username, password);
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