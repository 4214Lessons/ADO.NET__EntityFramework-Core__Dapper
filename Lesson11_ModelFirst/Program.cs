using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson11_ModelFirst
{
    public class Program
    {
        static void Main()
        {
            EntityDataModelContainer container = new EntityDataModelContainer();

            container.Categories.Add(new Category
            {
                Name = "A",
                Description = "B",
            });

            container.SaveChanges();


            var category = container.Categories.First();
            Console.WriteLine();

        }
    }
}
