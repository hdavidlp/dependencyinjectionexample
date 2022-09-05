using dependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dependencyInjection.Controllers
{
    [ApiController]  // Controller Atribute
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        private readonly IMessage _message;

        public HomeController(IMessage message)
        {
            _message = message ?? throw new ArgumentNullException(nameof(message));
        }

        [HttpGet("{message}")]
        public IActionResult sendMessage(string message)
        {
            if (message == null) return BadRequest();

            return Ok(_message.Send(message)); 
        }
    }
}
