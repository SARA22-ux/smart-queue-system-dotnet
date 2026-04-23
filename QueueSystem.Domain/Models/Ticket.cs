using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Domain.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; }
        public int Number { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsServed { get; set; }
    }
  
    }
