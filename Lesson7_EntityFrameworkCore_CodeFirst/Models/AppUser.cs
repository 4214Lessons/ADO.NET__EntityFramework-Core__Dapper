using Lesson7_EntityFrameworkCore_CodeFirst.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson7_EntityFrameworkCore_CodeFirst.Models;


public class AppUser : BaseEntity
{
    // [Key]
    public string UserName { get; set; }
    public string Password { get; set; }

    //[NotMapped]
    public string RePassword { get; set; }
    public Roles Role { get; set; }



    // Navigation property
    public AppUserDetail AppUserDetail { get; set; }
    public List<Order> Orders { get; set; }
}