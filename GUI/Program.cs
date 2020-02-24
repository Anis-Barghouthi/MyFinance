using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Services;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProduct sp = new ServiceProduct();
            Product p = new Product()
            {
                DateProd = new DateTime(2020, 11, 25),
                Description = "Tomate",
                Name = "Tomate",
                Price = 7000,
                Quantity = 1000
            };
            sp.AddProduct(p);
            sp.Commit();
            Console.WriteLine("Base créée avec succès");
            Console.ReadKey();
        }
    }
}