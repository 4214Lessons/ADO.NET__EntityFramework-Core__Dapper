﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Lesson10_EntityFrameworkCore.Models;

namespace Lesson10_EntityFrameworkCore.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.Name)
                 .IsRequired()
                 .HasMaxLength(30)
                 .HasDefaultValue("Default");


        builder.HasQueryFilter(x => x.CreatedDate < new DateTime(2000, 1, 1));
    }
}