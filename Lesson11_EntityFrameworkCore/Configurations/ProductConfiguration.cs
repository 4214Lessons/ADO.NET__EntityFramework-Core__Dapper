using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Lesson11_EntityFrameworkCore.Models;

namespace Lesson11_EntityFrameworkCore.Configurations;


public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.Name)
                 .HasMaxLength(40);

        builder.Property(x => x.UnitPrice)
                 .HasColumnType("money");


        builder.HasOne<Category>()
               .WithMany()
               .HasForeignKey(x => x.CategoryId)
               .OnDelete(DeleteBehavior.Cascade);


        builder.HasOne<Supplier>()
               .WithMany()
               .HasForeignKey(x => x.SupplierId);


        builder.HasData(GetProducts());
    }



    private static Product[] GetProducts() => new Product[]
    {
         new(){ Id = 1, Name = "Chai", SupplierId = 1, CategoryId = 1, UnitPrice = 18.00M, UnitsInStock = 39 },
         new(){ Id = 2, Name = "Chang", SupplierId = 1, CategoryId = 1, UnitPrice = 19.00M, UnitsInStock = 17 },
         new(){ Id = 3, Name = "Aniseed Syrup", SupplierId = 1, CategoryId = 2, UnitPrice = 10.00M, UnitsInStock = 13 },
         new(){ Id = 4, Name = "Chef Anton's Cajun Seasoning", SupplierId = 2, CategoryId = 2, UnitPrice = 22.00M, UnitsInStock = 53 },
         new(){ Id = 5, Name = "Chef Anton's Gumbo Mix", SupplierId = 2, CategoryId = 2, UnitPrice = 21.35M, UnitsInStock = 0 },
         new(){ Id = 6, Name = "Grandma's Boysenberry Spread", SupplierId = 3, CategoryId = 2, UnitPrice = 25.00M, UnitsInStock = 120 },
         new(){ Id = 7, Name = "Uncle Bob's Organic Dried Pears", SupplierId = 3, CategoryId = 7, UnitPrice = 30.00M, UnitsInStock = 15 },
         new(){ Id = 8, Name = "Northwoods Cranberry Sauce", SupplierId = 3, CategoryId = 2, UnitPrice = 40.00M, UnitsInStock = 6 },
         new(){ Id = 9, Name = "Mishi Kobe Niku", SupplierId = 4, CategoryId = 6, UnitPrice = 97.00M, UnitsInStock = 29 },
         new(){ Id = 10, Name = "Ikura", SupplierId = 4, CategoryId = 8, UnitPrice = 31.00M, UnitsInStock = 31 },
         new(){ Id = 11, Name = "Queso Cabrales", SupplierId = 5, CategoryId = 4, UnitPrice = 21.00M, UnitsInStock = 22 },
         new(){ Id = 12, Name = "Queso Manchego La Pastora", SupplierId = 5, CategoryId = 4, UnitPrice = 38.00M, UnitsInStock = 86 },
         new(){ Id = 13, Name = "Konbu", SupplierId = 6, CategoryId = 8, UnitPrice = 6.00M, UnitsInStock = 24 },
         new(){ Id = 14, Name = "Tofu", SupplierId = 6, CategoryId = 7, UnitPrice = 23.25M, UnitsInStock = 35 },
         new(){ Id = 15, Name = "Genen Shouyu", SupplierId = 6, CategoryId = 2, UnitPrice = 15.50M, UnitsInStock = 39 }
    };
}