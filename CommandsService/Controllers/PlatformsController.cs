//3:50:00
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers;

[Route("api/c/[controller]")]
[ApiController]
public class PlatformsController : ControllerBase
{

    public PlatformsController()
    {

    }
    [HttpPost]
    public ActionResult TestInboundConnection()
    {
        Console.WriteLine("-->Test Inbound");
        return Ok("Test of Inbound connection");
    }
}

