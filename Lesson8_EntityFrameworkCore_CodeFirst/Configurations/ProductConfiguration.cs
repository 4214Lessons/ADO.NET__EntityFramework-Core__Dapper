using Lesson8_EntityFrameworkCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Lesson8_EntityFrameworkCore_CodeFirst.Configurations;


public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.UnitPrice)
                 .IsRequired()
                 .HasDefaultValue(0M)
                 .HasColumnType("decimal(15,2)");


        builder.HasOne<Category>()
               .WithMany()
               .HasForeignKey(x=>x.CategoryId);
    }
}