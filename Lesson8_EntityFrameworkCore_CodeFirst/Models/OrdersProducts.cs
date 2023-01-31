namespace Lesson8_EntityFrameworkCore_CodeFirst.Models;


public class OrdersProducts : BaseEntity
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
}