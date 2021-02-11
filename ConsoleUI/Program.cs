using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // IoC will be  leant

            //InMemoryTest();
            // ProductTest();
            //CategoryTest();
            //ProductDetailDtoTest();

            ProductGetAllTest();


        }

        private static void ProductDetailDtoTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            Console.WriteLine("-***********-");
            if (result.Success)
            {
                foreach (var product in result.Entity)
                {
                    Console.WriteLine(product.ProductId + "---- " + product.CategoryName + "--- " + product.ProductName);
                }
                Console.WriteLine("\n****"+result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }

        private static void ProductGetAllTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetAll();

            Console.WriteLine("-***********-");
            if (result.Success)
            {
                foreach (var product in result.Entity)
                {
                    Console.WriteLine(product.ProductID + "---- " + product.UnitPrice + "--- " + product.ProductName);
                }
                Console.WriteLine("-***********-");
                Console.WriteLine(result.Message);
                Console.WriteLine("-***********-");
            }
            else
            {
                Console.WriteLine("-***********-");
                Console.WriteLine(result.Message);
                Console.WriteLine("-***********-");
            }


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            Console.WriteLine("Id ---- Category Name");
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryID + " --- " + category.CategoryName);
            }
        }

        private static void InMemoryTest()
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            var result = productManager.GetAll();

            if (result.Success)
            {
                foreach (var product in result.Entity )
                {
                    Console.WriteLine(product.CategoryID + "---- " + product.ProductID + "--- " + product.ProductName);
                }
                Console.WriteLine("-***********-");
                Console.WriteLine(result.Message);
                Console.WriteLine("-***********-");
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetByUnitPrice(50, 100);

            if (result.Success)
            {
                foreach (var product in result.Entity)
                {
                    Console.WriteLine(product.CategoryID + "---- " + product.ProductID + "--- " + product.ProductName);
                }
                Console.WriteLine("-***********-");
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            

            
        }
    }
}
