using Lesson7_EntityFrameworkCore_CodeFirst.Contexts;
using Lesson7_EntityFrameworkCore_CodeFirst.Models;



using ShopDbContext context = new ShopDbContext();

//context.Categories.Add(new Category()
//{
//    Name = "Notebook",
//    Description = "Notebook Description"
//});




//for (int i = 1; i < 100; i++)
//{
//    context.Products.Add(new Product()
//    {
//        Name = $"Iphone {i} Pro Max",
//        UnitInStock = (short)Random.Shared.Next(10, 100),
//        UnitPrice = Random.Shared.Next(1000, 10000) / 10.0M,
//        CategoryId = 1,
//    });
//}

context.SaveChanges();





var list = context.Products .Where(x => x.Id < 10)
                            .Select(x => new
                                    {
                                        x.Id,
                                        x.Name,
                                        x.UnitPrice,
                                        x.UnitInStock
                                    })
                            .OrderBy(x => x.UnitPrice);

foreach (var p in list)
{
    Console.WriteLine($"{p.Id} {p.Name} {p.UnitPrice} {p.UnitInStock}");
}





// Classes

// User
// UserDetail
// Category
// Product
// Order
// OrderDetail



// One to One
// AppUser
// AppUserDetail


// One to Many
// Category Product
// AppUser Order



// Many to Many
// Order Product
// OrderProduct {third table}