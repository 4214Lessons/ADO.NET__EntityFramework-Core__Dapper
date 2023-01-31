using Microsoft.EntityFrameworkCore;

namespace Lesson9_EntityFrameworkCore_DbFirst.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Test;Integrated Security=True");
    }
}