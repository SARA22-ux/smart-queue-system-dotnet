using Microsoft.AspNetCore.Mvc;
using QueueSystem.Application.Interfaces;
using QueueSystem.Application.Services;

namespace QueueSystem.API.Controllers
{
    [ApiController]
    [Route("api/queue")]
    public class QueueController : ControllerBase
    {
        private readonly IQueueService _service;

        public QueueController(IQueueService service)
        {
            _service = service;
        }

        [HttpPost("take")]
        public async Task<IActionResult> Take(string name)
        {
            var result = await _service.TakeTicket(name);
            return Ok(result);
        }

        [HttpGet("current")]
        public async Task<IActionResult> Current()
        {
            var result = await _service.GetCurrent();
            return Ok(result);
        }
    }
}