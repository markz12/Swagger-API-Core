using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwaggAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoAPIController : ControllerBase
    {
        [HttpGet]
        public IActionResult DemoSwagger()
        {
            return Ok();
        }
    }
}