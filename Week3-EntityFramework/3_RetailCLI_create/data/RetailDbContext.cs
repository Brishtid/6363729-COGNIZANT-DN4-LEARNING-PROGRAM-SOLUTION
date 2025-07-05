using Microsoft.EntityFrameworkCore;
using _3_RetailCLI.Models;

namespace _3_RetailCLI.Data
{
    public class RetailDbContext : DbContext
    {
        public RetailDbContext(DbContextOptions<RetailDbContext> options)
            : base(options)
        {
        }
//6363729
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}