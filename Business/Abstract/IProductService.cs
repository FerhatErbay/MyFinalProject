using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);
    }
}
