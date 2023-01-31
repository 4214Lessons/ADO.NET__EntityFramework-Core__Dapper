using Lesson8_EntityFrameworkCore_CodeFirst.Configurations;
using Lesson8_EntityFrameworkCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson8_EntityFrameworkCore_CodeFirst.Contexts;

public class ShopDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ShopDb;Integrated Security=True");
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


    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<AppUserDetail> AppUserDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrdersProducts> OrdersProducts { get; set; }
}