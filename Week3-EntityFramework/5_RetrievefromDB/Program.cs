using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


class Program
{
    static async Task Main(string[] args)
    {
        //6363729
        using var context = new RetailDbContext();

        if (!await context.Products.AnyAsync())
        {
            //6363729
            context.Products.AddRange(
                new Product { Name = "Laptop", Price = 55000 },
                new Product { Name = "Smartphone", Price = 25000 },
                new Product { Name = "Headphones", Price = 3000 }
            );

            await context.SaveChangesAsync();
            Console.WriteLine("Seed data inserted.");
        }

        // Retrieve all products
        var products = await context.Products.ToListAsync();
        Console.WriteLine("All Products:");
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - ₹{p.Price}");

        // product by ID
        var product = await context.Products.FindAsync(1);
        Console.WriteLine($"\nFound: {product?.Name}");

        // expensive product
        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"\nExpensive: {expensive?.Name}");
    }
}