using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nhom2.Ecom.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld()
        {
            return Content("Hello World!");
        }

        [HttpGet("GetSampleData")]
        public IActionResult GetSamepleData()
        {
            return new ObjectResult("This is data");
        }
    }
}