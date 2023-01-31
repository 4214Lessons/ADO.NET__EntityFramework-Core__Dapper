using Lesson9_EntityFrameworkCore_DbFirst_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

using var libraryContext = new LibraryContext();


// Related Data Load
// 1) Eager loading
// 2) Explicit loading
// 3) Lazy loading






// 1) Eager loading

{

    //var authors = libraryContext.Authors
    //                            .Include(a => a.Books)
    //                            .ThenInclude(b => b.IdCategoryNavigation)
    //                            .Include(a => a.Books)
    //                            .ThenInclude(b => b.IdThemesNavigation)
    //                            .ToList();


    //Console.WriteLine();


    //foreach (var author in authors)
    //{
    //    Console.WriteLine($"\n\n\t{author.Id} {author.FirstName} {author.LastName}");

    //    foreach (var book in author.Books)
    //    {
    //        Console.WriteLine($"{book.Id} {book.YearPress} {book.Pages} {book.Name}");
    //    }
    //}
}








{
    //// 2) Explicit loading

    //var author = libraryContext.Authors.First();
    //var book = libraryContext.Books.First();

    //Console.WriteLine();

    //if (true)
    //{
    //    Console.WriteLine();

    //    libraryContext.Entry(author).Collection(x => x.Books).Load();
    //    Console.WriteLine("==========");
    //    libraryContext.Entry(book).Reference(x => x.IdCategoryNavigation).Load();
    //    // libraryContext.Books.Include(x => x.IdAuthor == author.Id);

    //}
}





{
    // 3) Lazy loading

    var authors = libraryContext.Authors.ToList();

    Console.WriteLine();
    // Console.WriteLine(author.Books.Count);


    // (N + 1 Problem)

    foreach (var author in authors)
    {
        foreach (var book in author.Books)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine(author.Books.Count);
    }
}






{

    // foreach (var author in libraryContext.Authors.TagWith(@"Program.cs| Line 8"))
    // {
    //     Console.WriteLine($"\n\n\t{author.Id} {author.FirstName} {author.LastName}");
    // }
    // 
    // 
    // 
    // foreach (var author in libraryContext.Authors.TagWith("Controller.cs| Line 22"))
    // {
    //     Console.WriteLine($"\n\n\t{author.Id} {author.FirstName} {author.LastName}");
    // }

}









//foreach (var author in libraryContext.Authors.Include(x => x.Books))
//{
//      Console.ForegroundColor = ConsoleColor.Green;
//      Console.WriteLine($"\n\n\t{author.Id} {author.FirstName} {author.LastName}");
//      Console.ForegroundColor = ConsoleColor.White;

//    foreach (var book in author.Books)
//    {
//        Console.WriteLine($"{book.Id} {book.YearPress} {book.Pages} {book.Name}");
//    }
//}