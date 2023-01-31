using Lesson8_EntityFrameworkCore_CodeFirst.Enums;


namespace Lesson8_EntityFrameworkCore_CodeFirst.Models;


public class AppUser : BaseEntity
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string RePassword { get; set; }
    public Roles Role { get; set; }
}