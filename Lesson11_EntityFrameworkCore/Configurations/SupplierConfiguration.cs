using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Lesson11_EntityFrameworkCore.Models;

namespace Lesson11_EntityFrameworkCore.Configurations;



public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.Property(x => x.CompanyName)
                 .HasMaxLength(30);

        builder.Property(x => x.Address)
                 .HasMaxLength(60);

        builder.Property(x => x.Address)
                .HasMaxLength(24);


        builder.HasData(GetSuppliers());
    }


    private static Supplier[] GetSuppliers() => new Supplier[]
    {
        new(){ Id = 1, CompanyName = "Exotic Liquids", Address = "49 Gilbert St.", Phone = "(171) 555-2222" },
        new(){ Id = 2, CompanyName = "New Orleans Cajun Delights", Address = "P.O. Box 78934", Phone = "(100) 555-4822" },
        new(){ Id = 3, CompanyName = "Grandma Kelly's Homestead", Address = "707 Oxford Rd.", Phone = "(313) 555-5735" },
        new(){ Id = 4, CompanyName = "Tokyo Traders", Address = "Sekimai Musashino-shi", Phone = "(03) 3555-5011" },
        new(){ Id = 5, CompanyName = "Cooperativa de Quesos", Address = "Calle del Rosal 4", Phone = "(98) 598 76 54" },
        new(){ Id = 6, CompanyName = "Mayumi's", Address = "92 Setsuko Chuo-ku", Phone = "(06) 431-7877" }
    };
}