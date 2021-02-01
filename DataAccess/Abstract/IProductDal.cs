using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        Product GetById(int id);

        List<Product> GetAll();

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);
    }
}
