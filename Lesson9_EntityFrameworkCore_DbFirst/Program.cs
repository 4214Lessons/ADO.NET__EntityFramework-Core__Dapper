using Lesson9_EntityFrameworkCore_DbFirst.DAL;
using Lesson9_EntityFrameworkCore_DbFirst.Models;
using Microsoft.EntityFrameworkCore;




//using var context = new AppDbContext();


//foreach (var p in context.Products)
//{
//    Console.WriteLine($"{p.Id} {p.Name} {p.UnitPrice} {p.Description}");
//}




using var libraryContext = new LibraryContext();


foreach (var author in libraryContext.Authors.Include(x => x.Books))
{
    Console.WriteLine($"\n\n\t{author.Id} {author.FirstName} {author.LastName}");

    foreach (var book in author.Books)
    {
        Console.WriteLine($"{book.Id} {book.YearPress} {book.Pages} {book.Name}");
    }
}