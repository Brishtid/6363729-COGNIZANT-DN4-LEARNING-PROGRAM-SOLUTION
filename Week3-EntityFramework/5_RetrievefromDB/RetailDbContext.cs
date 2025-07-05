using Microsoft.EntityFrameworkCore;
//6363729
public class RetailDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RetailDb;Trusted_Connection=True;");
    }
}
