using Lesson10_EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson10_EntityFrameworkCore.Configurations;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        // builder.HasKey("UserName");
        // builder.Ignore("RePassword");

        builder.Ignore(x => x.RePassword);
    }
}