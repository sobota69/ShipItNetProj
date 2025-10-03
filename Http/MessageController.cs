using Microsoft.AspNetCore.Mvc;
using ShipItNetProj.Services;

namespace ShipItNetProj.Http;

[ApiController]
[Route("api/[controller]")]
public class MessageController(IMessageServiceWrapper messageServiceWrapper) : ControllerBase
{
    [HttpPost]
    public ActionResult SendMessage([FromBody] string message)
    {
        messageServiceWrapper.SendMessage(message);
        return Ok();
    }

}