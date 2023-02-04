using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Lesson10_EntityFrameworkCore.Models;

namespace Lesson10_EntityFrameworkCore.Configurations;


public class AppUserDetailConfiguration : IEntityTypeConfiguration<AppUserDetail>
{
    public void Configure(EntityTypeBuilder<AppUserDetail> builder)
    {
        builder.Property(x => x.FirstName)
                 .IsRequired()
                 .HasDefaultValue("No name")
                 .HasColumnName("Name");


        builder.Property(x => x.LastName)
               .IsRequired()
               .HasDefaultValue("No surname")
               .HasColumnName("Surname");


        builder.HasOne<AppUser>()
                .WithOne()
                .HasForeignKey<AppUserDetail>(x => x.AppUserId);
    }
}