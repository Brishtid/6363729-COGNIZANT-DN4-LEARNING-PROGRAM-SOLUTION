// Program.cs
using System;

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(245, "Shoes", "Footwear"),
            new Product(321, "Book", "Stationery"),
            new Product(490, "Headphones", "Electronics"),
            new Product(576, "Mobile", "Electronics")
        };

        
        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

        string searchItem = "Mobile";

        Console.WriteLine("Using Linear Search:");
        var result1 = SearchAlgorithms.LinearSearch(products, searchItem);
        Console.WriteLine(result1 != null ? $"Found: {result1.ProductName}" : "Product not found");

        Console.WriteLine("\n Using Binary Search:");
        var result2 = SearchAlgorithms.BinarySearch(products, searchItem);
        Console.WriteLine(result2 != null ? $"Found: {result2.ProductName}" : "Product not found");
    }
}
