using Lesson8_EntityFrameworkCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson8_EntityFrameworkCore_CodeFirst.Configurations;

public class OrdersProductsConfigurations : IEntityTypeConfiguration<OrdersProducts>
{
    public void Configure(EntityTypeBuilder<OrdersProducts> builder)
    {
        builder.Ignore(x=>x.Id);
        builder.Ignore(x=>x.CreatedDate);
        builder.Ignore(x=>x.ModifiedDate);
        // builder.HasKey(x => new { x.ProductId, x.OrderId });


        builder.HasNoKey();



        builder.HasOne<Order>()
             .WithMany()
             .HasForeignKey(x => x.OrderId);



        builder.HasOne<Product>()
           .WithMany()
           .HasForeignKey(x => x.ProductId);

    }
}