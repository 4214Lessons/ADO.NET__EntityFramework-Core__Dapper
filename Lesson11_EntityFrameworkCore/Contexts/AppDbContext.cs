using Lesson11_EntityFrameworkCore.Configurations;
using Lesson11_EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;


namespace Lesson11_EntityFrameworkCore.Contexts;


#nullable disable


public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Product> Products { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configurationRoot = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", true, true)
           .Build();

        var conStr = configurationRoot.GetConnectionString("conStr");

        optionsBuilder
            .LogTo(Console.WriteLine, LogLevel.Information)
            .UseSqlServer(conStr);
    }
}