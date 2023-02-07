namespace Lesson11_EntityFrameworkCore.Models;


public class Product : BaseEntity
{
    public string Name { get; set; } = null!;
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public int? SupplierId { get; set; }
    public int? CategoryId { get; set; }
}