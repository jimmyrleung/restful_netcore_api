using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestfulCoreAPI.Models;
using RestfulCoreAPI.Services.Interfaces;
using RestfulCoreAPI.ViewModels;
using Tapioca.HATEOAS;

namespace RestfulCoreAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/people")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Create([FromBody]PersonViewModel person)
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

        [HttpGet("")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult GetAll()
        {
            try
            {
                return Ok(_personService.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.InnerException.Message });
            }
        }
    }
}