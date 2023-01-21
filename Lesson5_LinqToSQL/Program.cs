using System;
using System.Linq;

namespace Lesson5_LinqToSQL
{
    class Program
    {
        static void Main()
        {
            var context = new LibraryDataContext();


            // var result = from b in context.Books
            //              select b;




            //foreach (var book in result)
            //{
            //    Console.WriteLine(book.Name);
            //}




            // var book = context.Books.FirstOrDefault(b => b.Id == 1);
            // Console.WriteLine(book.Name);



            // var result = from book in context.Books
            //              group book by book.Id_Category into g
            //              select new
            //              {
            //                  CategoryId = g.Key,
            //                  TotalPages = g.Sum(b => b.Pages)
            //              };



            // var result = from b in context.Books
            //              group b by new { b.Id_Category, b.Name } into g
            //              select new
            //              {
            //                  CategoryId = g.Key.Id_Category,
            //                  g.Key.Name,
            //                  TotalPages = g.Sum(b => b.Pages)
            //              };



            // var result = context.Books
            //     .GroupBy(b => b.Id_Category)
            //     .Select(g => new { g.Key, Sum = g.Sum(b => b.Pages), Count = g.Count() })
            //     .OrderByDescending(b => b.Count)
            //     .Skip(1)
            //     .Take(3);





            // var result = from book in context.Books
            //              where book.Id == (from b in context.Books
            //                                orderby b.Pages descending
            //                                select b.Id).Take(1).First()
            //              select book;







            // var result = from b in context.Books
            //              join a in context.Authors
            //              on b.Id_Author equals a.Id
            //              select new { b.Name, a.FirstName };








            // // Insert 
            // 
            // context.Authors.InsertOnSubmit(
            //         new Author
            //         {
            //             Id = 1001,
            //             FirstName = "Emin",
            //             LastName = "Velizade"
            //         }
            //     );
            // 
            // context.SubmitChanges();






            // // Update
            // var author = context.Authors.FirstOrDefault(a => a.Id == 1001);
            // author.FirstName = "Nicat";
            // author.LastName = "Ceferli";
            // 
            // context.SubmitChanges();





            // // Delete
            // var author = context.Authors.FirstOrDefault(a => a.Id == 2);
            // context.Authors.DeleteOnSubmit(author);
            // context.SubmitChanges();
        }
    }
}