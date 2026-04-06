using Microsoft.EntityFrameworkCore;
using QueueSystem.Domain.Models;

namespace QueueSystem.Infrastructure.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }
        // أي DbSet آخر
    }
}