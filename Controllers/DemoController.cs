using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicDotNetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Method1()
        {
            return Ok("Success");
        }

        [HttpGet]
        [Route("method2/{id}")]
        public IActionResult Method2([FromRoute] int id)
        {
            return Ok(new { message = id });
        }

        [HttpPost]
        [Route("method3")]
        public IActionResult Method3(string name)
        {
            return Ok(new {message = name });
        }
    }
        
}
