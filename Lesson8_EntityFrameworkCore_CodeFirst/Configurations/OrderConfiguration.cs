using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Lesson8_EntityFrameworkCore_CodeFirst.Models;

namespace Lesson8_EntityFrameworkCore_CodeFirst.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasOne<AppUser>()
               .WithMany()
               .HasForeignKey(x => x.AppUserId);
    }
}