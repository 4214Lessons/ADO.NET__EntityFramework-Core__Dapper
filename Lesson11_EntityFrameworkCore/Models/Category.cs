namespace Lesson11_EntityFrameworkCore.Models;


public class Category : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}