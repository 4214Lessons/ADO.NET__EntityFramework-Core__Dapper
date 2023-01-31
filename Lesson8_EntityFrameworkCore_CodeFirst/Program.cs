using Lesson8_EntityFrameworkCore_CodeFirst.Contexts;
using Lesson8_EntityFrameworkCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

using ShopDbContext context = new ShopDbContext();




//var list = context.Products .Where(x => x.Id < 10)
//                            .Select(x => new
//                                    {
//                                        x.Id,
//                                        x.Name,
//                                        x.UnitPrice,
//                                        x.UnitInStock
//                                    })
//                            .OrderBy(x => x.UnitPrice);



// foreach (var p in list)
// {
//     Console.WriteLine($"{p.Id} {p.Name} {p.UnitPrice} {p.UnitInStock}");
// }





var p = context.Products.Find(1);
Console.WriteLine($"{p.Id} {p.Name} {p.UnitPrice} {p.UnitInStock}");



context.Categories.Where(x => x.Id > 4);
context.Categories.Where(x => x.Id > 4);
context.Categories.Where(x => x.Id > 4);
context.Categories.IgnoreQueryFilters().Where(x => x.Id > 4);




// Convertional
// Data annotation
// Fluent API