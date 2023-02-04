namespace Lesson10_EntityFrameworkCore.Models;


public class Order : BaseEntity
{
    public string Address { get; set; }

    public int AppUserId { get; set; }
}