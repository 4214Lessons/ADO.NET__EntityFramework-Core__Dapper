using System;
using System.Collections.Generic;

namespace Lesson9_EntityFrameworkCore_DbFirst_2.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
