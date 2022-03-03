using Microsoft.AspNetCore.Mvc;

namespace SkyExplorer.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("It works");
    }
}