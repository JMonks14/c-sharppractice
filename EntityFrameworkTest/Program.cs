using EntityFrameworkTest.Models;
using System;
using System.Linq;

namespace EntityFrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using Data.EntityFrameworkTestContext context = new Data.EntityFrameworkTestContext();

            var squeakyBone = context.Products
                .Where(p => p.Name == "Squeaky Dog Bone")
                .FirstOrDefault();

            if (squeakyBone is Product)
            {
                squeakyBone.Price = 7.99m;
                //context.Remove(squeakyBone); to remove record from db
            }
                

            context.SaveChanges();
            
            var products = context.Products
                .Where(p => p.Price >= 5.00m)
                .OrderBy(p => p.Name);

            //equivalent in LINQ syntax
            //var products = from product in context.Products
            //               where product.Price > 5.00m
            //               orderby product.Name
            //               select product;

            foreach (Product p in products)
            {
                Console.WriteLine($"ID:     {p.Id}");
                Console.WriteLine($"Name:   {p.Name}");
                Console.WriteLine($"Price:  {p.Price}");
                Console.WriteLine(new string('_', 20));
            }
        }
    }
}
