using Lesson8_EntityFrameworkCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson8_EntityFrameworkCore_CodeFirst.Configurations;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        // builder.HasKey("UserName");
        // builder.Ignore("RePassword");

        builder.Ignore(x => x.RePassword);
    }
}