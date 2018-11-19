using Microsoft.AspNetCore.Mvc;
using RestfulCoreAPI.Services.Interfaces;
using System;

namespace RestfulCoreAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("")]
        public ActionResult GetAll()
        {
            try
            {
                return Ok(_bookService.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.InnerException.Message });
            }
        }
    }
}