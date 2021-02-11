using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();

        IDataResult<Product> GetById(int productId);

        IResult Add(Product product);

        void Update(Product product);

        void Delete(Product product);

        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}
