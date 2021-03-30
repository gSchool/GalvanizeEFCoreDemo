using GalvanizeCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GalvanizeCoreDemo.Data
{
    public class GalvanizeCoreDbContext : DbContext
    {
        public GalvanizeCoreDbContext(DbContextOptions<GalvanizeCoreDbContext> options) : base(options) {}
        public DbSet<Customer> Customers { get; set;}
    }
}