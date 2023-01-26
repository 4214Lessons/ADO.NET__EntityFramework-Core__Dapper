namespace Lesson7_EntityFrameworkCore_CodeFirst.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }


    // Navigation property
    public List<Product> Products { get; set; }
}