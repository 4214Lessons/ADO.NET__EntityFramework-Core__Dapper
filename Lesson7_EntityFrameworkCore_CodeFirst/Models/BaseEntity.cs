namespace Lesson7_EntityFrameworkCore_CodeFirst.Models;


public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }


    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
    }
}