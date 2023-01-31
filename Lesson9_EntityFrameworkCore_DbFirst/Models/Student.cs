using System;
using System.Collections.Generic;

namespace Lesson9_EntityFrameworkCore_DbFirst.Models
{
    public partial class Student
    {
        public Student()
        {
            SCards = new HashSet<SCard>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int IdGroup { get; set; }
        public int Term { get; set; }

        public virtual Group IdGroupNavigation { get; set; } = null!;
        public virtual ICollection<SCard> SCards { get; set; }
    }
}
