using Microsoft.EntityFrameworkCore;
using NorthWind.Domain.Models;

namespace NorthWind.Domain.Models
{
    public class NorthWindContext : DbContext
    {
        public NorthWindContext(DbContextOptions<NorthWindContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
