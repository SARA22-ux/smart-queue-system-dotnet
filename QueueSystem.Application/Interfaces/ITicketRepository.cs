using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueSystem.Domain.Models;
using QueueSystem.Infrastructure.AppDbContext;

namespace QueueSystem.Application.Interfaces
{
    public interface ITicketRepository
    {
        Task<Ticket> AddTicket(string name);
        Task<Ticket> GetCurrentTicket();
    }
}
