using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsOfStock=100},
                new Product{ProductId=2, CategoryId=1, ProductName="Vazo", UnitPrice=25, UnitsOfStock=500},
                new Product{ProductId=3, CategoryId=2, ProductName="Mouse", UnitPrice=35, UnitsOfStock=250},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=50, UnitsOfStock=300},
                new Product{ProductId=5, CategoryId=2, ProductName="USB FlashDisk", UnitPrice=30, UnitsOfStock=200}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // Product productDeleted = null;

            //foreach (var p in _products)
            //{
            //    if (product.ProductId==p.ProductId)
            //    {
            //        productDeleted = p;
            //    }
            //}

            //( => lambda) LINQ - Language Integrated Query
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public Product GetById(int id)
        {
            return _products.SingleOrDefault(p => p.ProductId == id);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsOfStock = product.UnitsOfStock;
        }

    }
}
