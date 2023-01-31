namespace Lesson8_EntityFrameworkCore_CodeFirst.Models;


public class Order : BaseEntity
{
    public string Address { get; set; }

    public int AppUserId { get; set; }
}