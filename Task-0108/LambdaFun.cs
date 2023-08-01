using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0108
{
    class Product
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public double Price { get; set;}    

    }
    internal class LambdaFun
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product { Id = 1, Name = "Football", Price = 1250 },
                new Product { Id = 2, Name = "Volleyball", Price = 900 },
                new Product { Id = 3, Name = "Basketball", Price = 1400 },
                new Product { Id = 4, Name = "Handball", Price = 1000 },
            };
            Console.WriteLine("Product Details in Descending Order");
            Console.WriteLine("-----------------");
            //Displaying in Descending Order
            var list2 = from p in list orderby p.Name descending select p;
            foreach (var item in list2)
            {
                Console.WriteLine($"Product ID : {item.Id}");
                Console.WriteLine($"Product Name : {item.Name}");
                Console.WriteLine($"Product Price : {item.Price}");
             
            }
            Console.WriteLine("\n");
            Console.WriteLine("Product Details - 2 properties");
            Console.WriteLine("-----------------");
            //retrieving any 2 properties 
            var list3 = list.Select(p => new { p.Id, p.Name });
            foreach(var item in list3)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("First Character of Product");
            Console.WriteLine("-----------------");
            //retrieving only first character from product name
            var list4 = list.Select(p => p.Name[0]);
            foreach(var item in list4)
            {
                Console.WriteLine($"First Character of Product is {item}");
            }
            Console.ReadLine();
        }
    }
}
