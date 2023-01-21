using System;
using System.Linq;
using System.Security.AccessControl;
{

    var students = new[]
    {
        "Nihat",
        "Nihat",
        "Huseyn",
        "Huseyn",
        "Emin",
        "Isa",
        "Resul",
        "Vasif",
        "Tural",
        "Kenan",
        "Elshad",
        "Ali",
        "Miri",
        "Royal",
        "Leyla"
    };


    // QuerySyntax();
    // MethodSyntax();





    void QuerySyntax()
    {
        // var result = from s in students
        //              where s.Length > 4
        //              select s;


        var result = (from s in students
                      where s.Length > 4
                      orderby s.Length descending
                      select s).Distinct();

        foreach (var item in result)
            Console.WriteLine(item);
    }


    void MethodSyntax()
    {
        var result = students.Where(x => x.Length < 5);

        foreach (var item in result)
            Console.WriteLine(item);
    }
}













{
    var products = new[]
    {
        new Product{ Id = 1, Name="Iphone", Price = 2689},
        new Product{ Id = 2, Name="Samsung", Price = 2530},
        new Product{ Id = 3, Name="Sony", Price = 1350},
        new Product{ Id = 4, Name="Mi", Price = 1980},
        new Product{ Id = 5, Name="Nokia", Price = 160},
    };




    {
        var maxPrice = products
            .Select(p => p.Price)
            .Max();


        // var maxPrice = products.MaxBy(p=>p.Price);
        // Console.WriteLine(maxPrice.Price);



        var prodCount = products.Count(p => p.Price > 100 && p.Price <= 1500);
        // Console.WriteLine(prodCount);
    }


    {
        // new { AnonymousType, Product }

        var result = from p in products
                     where p.Price > 500
                     orderby p.Price descending
                     select new CustomType
                     {
                        Name = p.Name,
                        Price =  p.Price
                     };


                // select new
                // {
                //     CustomName = p.Name,
                //     CustomPrice = p.Price
                // };

                // select (p.Name, p.Price);



        // foreach (var item in result)
        // {
        //     Console.WriteLine($"{item.Name} - {item.Price}");
        // }
    }





    {
        var result = from p in products
                     where p.Price < 500
                     orderby p.Price
                     select p.Name.ToUpper();

        //foreach (var productName in result)
        //{
        //    Console.WriteLine(productName);
        //}

    }
}



Console.ReadKey();