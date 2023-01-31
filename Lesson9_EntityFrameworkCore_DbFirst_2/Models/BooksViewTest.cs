using System;
using System.Collections.Generic;

namespace Lesson9_EntityFrameworkCore_DbFirst_2.Models;

public partial class BooksViewTest
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Pages { get; set; }

    public int YearPress { get; set; }

    public int Quantity { get; set; }
}
