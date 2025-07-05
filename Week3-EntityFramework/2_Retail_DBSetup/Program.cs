using System;
using System.Linq;
using RetailStoreApp.Data;
using RetailStoreApp.Models;

namespace RetailStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                
                context.Database.EnsureCreated();

               
                if (!context.Categories.Any())
                {
                    var electronics = new Category { Name = "Electronics" };
                    var groceries = new Category { Name = "Groceries" };

                    context.Categories.AddRange(electronics, groceries);
                    context.SaveChanges();
//6363729
                    
                    var product1 = new Product { Name = "Laptop", Price = 50000, CategoryId = electronics.Id };
                    var product2 = new Product { Name = "Headphones", Price = 1500, CategoryId = electronics.Id };
                    var product3 = new Product { Name = "Rice", Price = 60, CategoryId = groceries.Id };

                    context.Products.AddRange(product1, product2, product3);
                    context.SaveChanges();
                }

                
                var categoriesWithProducts = context.Categories
                    .Select(c => new {
                        CategoryName = c.Name,
                        Products = c.Products.Select(p => new { p.Name, p.Price })
                    });
//Brishti
               
                foreach (var category in categoriesWithProducts)
                {
                    Console.WriteLine($"\nCategory: {category.CategoryName}");
                    foreach (var product in category.Products)
                    {
                        Console.WriteLine($" - {product.Name}: {product.Price}");
                    }
                }
            }

            Console.WriteLine("\nData inserted and queried successfully!");
        }
    }
}
