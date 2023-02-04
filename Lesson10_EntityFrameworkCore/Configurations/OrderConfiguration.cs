using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Lesson10_EntityFrameworkCore.Models;

namespace Lesson10_EntityFrameworkCore.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasOne<AppUser>()
               .WithMany()
               .HasForeignKey(x => x.AppUserId);
    }
}