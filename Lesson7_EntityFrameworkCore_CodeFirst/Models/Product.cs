using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson7_EntityFrameworkCore_CodeFirst.Models;

public class Product : BaseEntity
{
    public string Name { get; set; }

    //[Column(TypeName = "decimal(15,2)")]
    public decimal UnitPrice { get; set; }
    public short UnitInStock { get; set; }


    // Foreign key
    public int CategoryId { get; set; }


    // Navigation property
    public Category Category { get; set; }
    public List<Order> Orders { get; set; }
}