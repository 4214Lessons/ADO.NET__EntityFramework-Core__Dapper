using Lesson10_EntityFrameworkCore.Configurations;
using Lesson10_EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Lesson10_EntityFrameworkCore.Contexts;


public class ShopDbContext : DbContext
{

    public ShopDbContext(){}


    public ShopDbContext(DbContextOptions<ShopDbContext> options)
        : base(options) { }




    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configurationRoot = new ConfigurationManager()
            .AddJsonFile("appsettings.json", true, true)
            .Build();

        var connectionString = configurationRoot.GetConnectionString("conStr");

        optionsBuilder
        //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
        .UseSqlServer(connectionString);


        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AppUserConfiguration());
        modelBuilder.ApplyConfiguration(new AppUserDetailConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new OrdersProductsConfigurations());

        base.OnModelCreating(modelBuilder);
    }




    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var item in ChangeTracker.Entries())
        {
            if(item.Entity is BaseEntity entity)
            {
                if(item.State == EntityState.Modified)
                    entity.ModifiedDate = DateTime.Now;
                else if (item.State == EntityState.Added)
                    entity.CreatedDate = DateTime.Now;
            }
        }


        return base.SaveChangesAsync(cancellationToken);
    }


    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<AppUserDetail> AppUserDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrdersProducts> OrdersProducts { get; set; }
}