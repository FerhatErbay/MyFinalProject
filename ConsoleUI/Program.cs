using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.CategoryId+" "+product.ProductId+" "+product.ProductName);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
