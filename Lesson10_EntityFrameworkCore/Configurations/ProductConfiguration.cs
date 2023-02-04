using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Lesson10_EntityFrameworkCore.Models;

namespace Lesson10_EntityFrameworkCore.Configurations;


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
               .HasForeignKey(x => x.CategoryId);
    }
}