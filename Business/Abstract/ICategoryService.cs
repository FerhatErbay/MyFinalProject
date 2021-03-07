using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //List<Category> GetAll();
        //Category GetById(int categoryId);

        IDataResult<List<Category>> GetAll();

        IDataResult<Category> GetById(int categoryId);

        IResult Add(Category category);

        IResult Update(Category category);

        IResult Delete(Category category);

        
    }
}
