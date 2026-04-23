using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using QueueSystem.Infrastructure.AppDbContext;
using QueueSystem.Application.Services;
using QueueSystem.Domain.Models;
using Microsoft.AspNetCore.Mvc;

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
