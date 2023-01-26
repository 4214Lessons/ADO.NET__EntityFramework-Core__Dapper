namespace Lesson7_EntityFrameworkCore_CodeFirst.Models;

public class Order : BaseEntity
{
    public string Address { get; set; }

    // Foreign key
    public int AppUserId { get; set; }


    // Navigation property
    public AppUser AppUser { get; set; }
    public List<Product> Products { get; set; }
}