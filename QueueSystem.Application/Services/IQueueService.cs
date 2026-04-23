using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueSystem.Application.Interfaces;
using QueueSystem.Domain.Models;
namespace QueueSystem.Application.Services
{
    public interface IQueueService
    {
        Task<Ticket> TakeTicket(string name);
        Task<Ticket> GetCurrent();
    }
}
