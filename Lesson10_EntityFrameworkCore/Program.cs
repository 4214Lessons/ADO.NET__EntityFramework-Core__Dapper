using Lesson10_EntityFrameworkCore;
using Lesson10_EntityFrameworkCore.Contexts;
using Lesson10_EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;




//var dbContextFactory = new DbContextFactory();
//using ShopDbContext context = dbContextFactory.CreateDbContext();





using var context = new ShopDbContext();


//foreach (var p in context.Products)
//{
//    Console.WriteLine($"{context.Entry(p).State} - {p.Name}");
//}



//var product = context.Products.First();
//var category = context.Categories.First();



//product.UnitPrice = 9990;
//category.Name = "MyName";



//await context.SaveChangesAsync();





// Tracking: OPEN (Default)



var newProduct = new Product()
{
    Name = "Iphone",
    UnitInStock = 10,
    UnitPrice = 2999,
    CategoryId = 1
};


//context.Products.AsNoTracking().ToList();
//context.Products.AsTracking().ToList();





//Console.WriteLine($"{context.Entry(newProduct).State} - {newProduct.Name}");

//await context.AddAsync(newProduct);
//context.Entry(newProduct).State = EntityState.Added;



//context.Remove(newProduct);
//context.Entry(newProduct).State = EntityState.Deleted;



//context.Update(newProduct);
//context.Entry(newProduct).State = EntityState.Modified;


// Console.WriteLine($"{context.Entry(newProduct).State} - {newProduct.Name}");





var product = context.Products.First();

// await context.Products.AddAsync(newProduct);


product.UnitPrice = 21312;


await context.SaveChangesAsync();









// unchanged
// added
// modifed
// unchanged
// deleted
// unchanged
// modifed
// unchanged
// unchanged
// unchanged
// unchanged
// unchanged


// 11
// SQL QUERY (1 added) (2 modifed) (3 deleted) (4 modifed)
