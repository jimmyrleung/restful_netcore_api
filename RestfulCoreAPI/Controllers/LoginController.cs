using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestfulCoreAPI.Services.Interfaces;
using RestfulCoreAPI.ViewModels;

namespace RestfulCoreAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/login")]
    public class LoginController : ControllerBase
    {
        private ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("")]
        [AllowAnonymous]
        public IActionResult Login ([FromBody]UserViewModel user)
        {
            if (user == null) return BadRequest();

            return Ok(_loginService.Login(user));
        }
    }
}