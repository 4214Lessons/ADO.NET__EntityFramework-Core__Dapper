using Lesson7_EntityFrameworkCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson7_EntityFrameworkCore_CodeFirst.Contexts;

public class ShopDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=ShopDb;Integrated Security=True;");
        base.OnConfiguring(optionsBuilder);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppUser>().Ignore("RePassword");
        //modelBuilder.Entity<AppUser>().HasKey("UserName");


        base.OnModelCreating(modelBuilder);
    }


    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<AppUserDetail> AppUserDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
}