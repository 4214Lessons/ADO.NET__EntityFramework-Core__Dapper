namespace Lesson10_EntityFrameworkCore.Models;


public class AppUserDetail : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public int AppUserId { get; set; }
}