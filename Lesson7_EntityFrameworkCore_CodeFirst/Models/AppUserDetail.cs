using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson7_EntityFrameworkCore_CodeFirst.Models;

public class AppUserDetail : BaseEntity
{
    //[Column("Name", Order = 2)]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }


    // Foreign key
    // [ForeignKey("AppUser")]
    public int AppUserId { get; set; }



    // Navigation property
    public AppUser AppUser { get; set; }
}