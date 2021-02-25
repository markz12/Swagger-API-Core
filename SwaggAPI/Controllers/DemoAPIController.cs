using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggAPI.Model;

namespace SwaggAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoAPIController : ControllerBase
    {
        [HttpGet(nameof(DemoSwagger))]
        public IActionResult DemoSwagger()
        {
            DemoTest demo = new DemoTest
            {
                testName = "Swagger here",
                testDescription = "This is for swagger api testing",
                testDate = DateTime.Now
            };
            return Ok(demo);
        }

        [HttpPost(nameof(DemoPostSwagger))]
        public IActionResult DemoPostSwagger(DemoTest demo)
        {
            //This will be used for testing.
            return Ok(demo);
        }

        [HttpPut(nameof(DemoPutSwagger))]
        public IActionResult DemoPutSwagger(string testName)
        {
            DemoTest demo = new DemoTest
            {
                testName = "MarkVanz Swagger",
                testDescription = "This is for swagger api testing",
                testDate = DateTime.Now
            };
            if (demo.testName.Equals(testName))
            {
                return Ok("Successfully Updated Swagger!");
            }
            else
            {
                return NotFound("Not found Swagger!");
            }
        }

        [HttpDelete(nameof(DemoDeleteSwagger))]
        public IActionResult DemoDeleteSwagger(string testName)
        {
            DemoTest demo = new DemoTest
            {
                testName = "MarkVanz Swagger",
                testDescription = "This is for swagger api testing",
                testDate = DateTime.Now
            };
            if (demo.testName.Equals(testName))
            {
                return Ok("Successfully Deleted Swagger!");
            }
            else
            {
                return NotFound("Not found Swagger!");
            }
        }
    }
}