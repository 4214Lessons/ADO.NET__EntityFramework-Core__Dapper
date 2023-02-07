using Lesson11_EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson11_EntityFrameworkCore.Configurations;


public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.Name)
                    .HasMaxLength(15);

        builder.Property(x => x.Description)
                    .HasColumnType("ntext");


        builder.HasData(GetCategories());
    }


    private  Category[] GetCategories() => new Category[]
    {
         new(){ Id = 1, Name = "Beverages", Description ="Soft drinks, coffees, teas, beers, and ales" },
         new(){ Id = 2, Name = "Condiments", Description ="Sweet and savory sauces, relishes, spreads, and seasonings" },
         new(){ Id = 3, Name = "Confections", Description ="Desserts, candies, and sweet breads" },
         new(){ Id = 4, Name = "Dairy Products", Description ="Cheeses" },
         new(){ Id = 5, Name = "Grains/Cereals", Description ="Breads, crackers, pasta, and cereal" },
         new(){ Id = 6, Name = "Meat/Poultry", Description ="Prepared meats" },
         new(){ Id = 7, Name = "Produce", Description ="Dried fruit and bean curd" },
         new(){ Id = 8, Name = "Seafood", Description ="Seaweed and fish" }
    };
}