using RetailInventory.Data;
using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;


using var context = new AppDbContext();


context.Database.EnsureCreated();

// brishti
if (!context.Categories.Any())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    context.Categories.AddRange(electronics, groceries);

    context.Products.AddRange(
        new Product { Name = "Laptop", QuantityInStock = 10, Category = electronics },
        new Product { Name = "Smartphone", QuantityInStock = 25, Category = electronics },
        new Product { Name = "Rice", QuantityInStock = 100, Category = groceries }
    );

    context.SaveChanges();
    Console.WriteLine("Sample data inserted.");
}
else
{
    Console.WriteLine("Categories already exist.");
}

//6363729
var products = context.Products.Include(p => p.Category).ToList();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - {p.Category.Name} - Stock: {p.QuantityInStock}");
}
