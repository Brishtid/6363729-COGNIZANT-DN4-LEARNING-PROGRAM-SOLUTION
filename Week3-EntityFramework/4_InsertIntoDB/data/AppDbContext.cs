using Microsoft.EntityFrameworkCore;
using _4_InsertIntoDB.Models;

namespace _4_InsertIntoDB.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RetailStoreDB;Trusted_Connection=True;");
        }
    }
}
