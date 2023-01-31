namespace Lesson8_EntityFrameworkCore_CodeFirst.Models;


public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
}