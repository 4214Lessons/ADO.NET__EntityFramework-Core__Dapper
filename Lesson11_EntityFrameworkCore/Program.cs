using Lesson11_EntityFrameworkCore.Contexts;
using Lesson11_EntityFrameworkCore.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;

using var context = new AppDbContext();


//Console.ForegroundColor = ConsoleColor.Green;

//foreach (var p in context.Products)
//{
//    Console.Write($"Id: {p.Id}\t");
//    Console.Write($"CategoryId: {p.CategoryId}\t");
//    Console.Write($"SupplierId: {p.SupplierId}\t");
//    Console.Write($"UnitsInStock:  {p.UnitsInStock}\t");
//    Console.Write($"UnitPrice: {p.UnitPrice}\t");
//    Console.Write($"Name: {p.Name}\t\n\n");
//}















///////////////////////////////////////////////////////////////
// Joins
// Inner join




//// Inner join (Method syntax)
//var resultInner = context.Products.Join(context.Categories, p => p.CategoryId, c => c.Id, (p, c) => new
//{
//    p.Id,
//    p.Name,
//    p.UnitPrice,
//    p.UnitsInStock,
//    CategoryName = c.Name
//});



//// Inner join (Query syntax)

//var resultInner = from p in context.Products
//                  join c in context.Categories on p.CategoryId equals c.Id
//                  select new
//                  {
//                      p.Id,
//                      p.Name,
//                      p.UnitPrice,
//                      p.UnitsInStock,
//                      CategoryName = c.Name
//                  };




//Console.ForegroundColor = ConsoleColor.White;
//Console.WriteLine("\nInner join\n");


//foreach (var item in resultInner)
//{
//    Console.Write($"{item.Id}".PadRight(10));
//    Console.Write($"{item.UnitsInStock}".PadRight(10));
//    Console.Write($"{item.UnitPrice}".PadRight(15));
//    Console.Write($"{item.CategoryName}".PadRight(20));
//    Console.WriteLine($"{item.Name}");
//}










//// Left join (Query syntax)
//var resultLeft = from p in context.Products
//                 join c in context.Categories 
//                 on p.CategoryId equals c.Id into grouping
//                 from g in grouping.DefaultIfEmpty()
//                 select new
//                  {
//                      p.Id,
//                      p.Name,
//                      p.UnitPrice,
//                      p.UnitsInStock,
//                      CategoryName = g.Name
//                  };



//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("\nLeft join\n");


//foreach (var item in resultLeft)
//{
//    Console.Write($"{item.Id}".PadRight(10));
//    Console.Write($"{item.UnitsInStock}".PadRight(10));
//    Console.Write($"{item.UnitPrice}".PadRight(15));
//    Console.Write($"{item.CategoryName}".PadRight(20));
//    Console.WriteLine($"{item.Name}");
//}




















//// Bir nece join

//Console.ForegroundColor = ConsoleColor.Green;

//var result = from p in context.Products
//             join c in context.Categories on p.CategoryId equals c.Id
//             join s in context.Suppliers on p.SupplierId equals s.Id
//             select new
//             {
//                 p.Id,
//                 p.Name,
//                 p.UnitPrice,
//                 p.UnitsInStock,
//                 s.CompanyName,
//                 CategoryName = c.Name
//             };



//foreach (var item in result)
//{
//    Console.Write($"{item.Id}".PadRight(10));
//    Console.Write($"{item.UnitsInStock}".PadRight(10));
//    Console.Write($"{item.UnitPrice}".PadRight(15));
//    Console.Write($"{item.CategoryName}".PadRight(20));
//    Console.Write($"{item.CompanyName}".PadRight(30));
//    Console.WriteLine($"{item.Name}");
//}

















///////////////////////////////////////////////////////////////
// Client vs Server Evaluation(qiymətləndirmə) { Next Lesson }

// Client - Memory tərəfdəki sorğular
// Server - SQL server tərəfdəki sorğular

// NOTE: EF - Əgər yazdiğımız sorğuları SQL sorgusuna çevirə bilmirsə Compile Time xəta verəcək.


















///////////////////////////////////////////////////////////////
// Raw Sql

// 1) FromSqlRaw
// 2) FromSqlInterpolated




// var products = context.Products.FromSqlRaw("SELECT * FROM Products");
// var products = context.Products.FromSqlRaw("SELECT * FROM Products WHERE Id < {0}", 3);
// var products = context.Products.FromSqlInterpolated($"SELECT * FROM Products WHERE Id < {3}");
// Console.WriteLine(products.ToList().Count);








// var x = context.Database.SqlQuery<int>($"Query").ToList(); // .NET 7






// context.TableCustom.FromSqlRaw("SELECT Name, Price FROM Products");
// modelBuilder.Entity<TableCustom>().HasNoKey();











///////////////////////////////////////////////////////////////
// View
 
var resultView = context.Products.FromSqlRaw("SELECT * FROM TestView");
Console.WriteLine(resultView.Count());








// ///////////////////////////////////////////////////////////////
// Procedure


// NOTE: Select edende "Context.TableName" uzerinden
// NOTE: Insert, update, delete "context.Database"



var outParam = new SqlParameter()
{
    Direction = ParameterDirection.Output,
    SqlDbType = SqlDbType.SmallInt,
};

await context.Database.ExecuteSqlInterpolatedAsync($"EXECUTE usp_addQuantity {1}, {10}, {outParam} out");

Console.WriteLine(outParam.Value);









// ///////////////////////////////////////////////////////////////
// Function Method

 
// 1) Scalar
// 2) Table












// ///////////////////////////////////////////////////////////////
// Transaction


//// BeginTransaction
//// Commit
//// Rollback



//using var transaction = await context.Database.BeginTransactionAsync();

//// doSomething 1
//await context.SaveChangesAsync();


//// doSomething 2
//await context.SaveChangesAsync();



//await transaction.CommitAsync();
//// or
//await transaction.RollbackAsync();









// ///////////////////////////////////////////////////////////////
// Model First