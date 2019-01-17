using Microsoft.AspNetCore.Mvc;
using RestfulCoreAPI.Services.Interfaces;
using RestfulCoreAPI.ViewModels;
using System;
using Tapioca.HATEOAS;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;

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
        [ProducesResponseType(typeof(IList<PersonViewModel>), 200)] // Swagger 4+
        //[SwaggerResponse((200), Type = typeof(IList<PersonViewModel>))] // Swagger 3
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