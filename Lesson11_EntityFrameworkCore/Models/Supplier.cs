namespace Lesson11_EntityFrameworkCore.Models;


public class Supplier : BaseEntity
{
    public string CompanyName { get; set; } = null!;
    public string? Address { get; set; }
    public string? Phone { get; set; }
}