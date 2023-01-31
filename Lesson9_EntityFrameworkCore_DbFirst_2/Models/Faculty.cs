using System;
using System.Collections.Generic;

namespace Lesson9_EntityFrameworkCore_DbFirst_2.Models;

public partial class Faculty
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
