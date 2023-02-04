using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Lesson10_EntityFrameworkCore.Contexts;
using Microsoft.Extensions.Configuration;

namespace Lesson10_EntityFrameworkCore;

public class DbContextFactory : IDesignTimeDbContextFactory<ShopDbContext>
{
    private readonly string _connectionString;

    public DbContextFactory()
    {
        var configurationRoot = new ConfigurationManager()
               .AddJsonFile("appsettings.json", true, true)
               .Build();

        _connectionString = configurationRoot.GetConnectionString("conStr");
    }


    public ShopDbContext CreateDbContext(string[] args = null)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ShopDbContext>()
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
            .UseSqlServer(_connectionString);

        return new ShopDbContext(optionsBuilder.Options);
    }
}