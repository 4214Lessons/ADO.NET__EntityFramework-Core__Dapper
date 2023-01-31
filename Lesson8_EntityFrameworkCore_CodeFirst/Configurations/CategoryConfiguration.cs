using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Lesson8_EntityFrameworkCore_CodeFirst.Models;

namespace Lesson8_EntityFrameworkCore_CodeFirst.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.Name)
                 .IsRequired()
                 .HasMaxLength(30)
                 .HasDefaultValue("Default");
    }
}