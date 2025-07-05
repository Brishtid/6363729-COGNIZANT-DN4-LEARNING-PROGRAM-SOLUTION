using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using _3_RetailCLI.Data;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        //6363729
        services.AddDbContext<RetailDbContext>(options =>
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RetailInventoryQn3Db"));
    });

var app = builder.Build();
Console.WriteLine("EF Core CLI project is configured.");
