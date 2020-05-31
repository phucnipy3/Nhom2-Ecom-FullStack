using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom2.Ecom.Data;

namespace Nhom2.Ecom.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DatabaseContext _db;
        private readonly IBLUsers _bLUser;

        public HomeController(DatabaseContext db, IBLUsers bLUser)
        {
            _db = db;
            _bLUser = bLUser;
        }

        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld()
        {
            _bLUser.Add(new Users());
            return Content("Hello World!");
        }

        [HttpGet("GetSampleData")]
        public IActionResult GetSamepleData()
        {
            return new ObjectResult("This is data");
        }
    }
}