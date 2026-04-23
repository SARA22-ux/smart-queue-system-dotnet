using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using QueueSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;
using QueueSystem.Application.Interfaces;
namespace QueueSystem.Application.Services
{
    public class QueueService : IQueueService
    {
        private static List<Ticket> _tickets = new List<Ticket>();

        public Task<Ticket> TakeTicket(string name)
        {
            var number = _tickets.Count + 1;

            var ticket = new Ticket
            {
                Id = Guid.NewGuid(),
                CustomerName = name,
                Number = number,
                CreatedAt = DateTime.Now,
                IsServed = false
            };

            _tickets.Add(ticket);

            return Task.FromResult(ticket);
        }

        public Task<Ticket> GetCurrent()
        {
            var current = _tickets
                .Where(t => !t.IsServed)
                .OrderBy(t => t.Number)
                .FirstOrDefault();

            return Task.FromResult(current);
        }
    }
}
