using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestfulCoreAPI.Models;
using RestfulCoreAPI.Services.Interfaces;

namespace RestfulCoreAPI.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("")]
        public ActionResult Create([FromBody]Person person)
        {
            try
            {
                return Ok(_personService.Create(person));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.InnerException.Message });
            }
        }
    }
}