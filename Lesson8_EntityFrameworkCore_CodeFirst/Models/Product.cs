namespace Lesson8_EntityFrameworkCore_CodeFirst.Models;


public class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitInStock { get; set; }
    public int CategoryId { get; set; }
}