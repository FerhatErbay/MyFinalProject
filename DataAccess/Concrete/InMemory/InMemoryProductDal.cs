using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductID=1, CategoryID=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=100},
                new Product{ProductID=2, CategoryID=1, ProductName="Vazo", UnitPrice=25, UnitsInStock=500},
                new Product{ProductID=3, CategoryID=2, ProductName="Mouse", UnitPrice=35, UnitsInStock=250},
                new Product{ProductID=4, CategoryID=2, ProductName="Klavye", UnitPrice=50, UnitsInStock=300},
                new Product{ProductID=5, CategoryID=2, ProductName="USB FlashDisk", UnitPrice=30, UnitsInStock=200}
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
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);

            _products.Remove(productToDelete);
        }

        

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public Product GetById(int id)
        {
            return _products.SingleOrDefault(p => p.ProductID == id);
        }

        public Product GetById(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

    }
}
