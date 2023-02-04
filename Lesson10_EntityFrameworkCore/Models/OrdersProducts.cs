namespace Lesson10_EntityFrameworkCore.Models;


public class OrdersProducts : BaseEntity
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
}