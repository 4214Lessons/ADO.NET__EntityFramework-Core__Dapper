using System;
using System.Collections.Generic;

namespace Lesson9_EntityFrameworkCore_DbFirst.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            Groups = new HashSet<Group>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Group> Groups { get; set; }
    }
}
