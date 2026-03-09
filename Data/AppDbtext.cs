using Microsoft.EntityFrameworkCore;
using secureapp.Models;

namespace secureapp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}