using Microsoft.AspNetCore.Mvc;
// using System;

namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("hello")]
        // [Route("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello, World!");
        }
    
        [HttpGet("test")]
        // [Route("hello")]
        public IActionResult GetTest()
        {
            var value = System.Environment.GetEnvironmentVariable("version");
            return Ok(value);
        }
        [HttpGet("liran")]
        // [Route("hello")]
        public IActionResult GetLiran()
        {
            // await client.GetAsync("http://user9-dotnet-app/user9-application:8080/Hello/hello")
            await client.GetAsync("http://user9-dotnet-app.user9-application:8080/Hello/hello");
            var value = System.Environment.GetEnvironmentVariable("version");
            return Ok(value);
        }
    }
}
