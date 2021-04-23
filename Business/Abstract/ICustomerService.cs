using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> Get(string str);

        IDataResult<List<Customer>> GetAll();

        IDataResult<Customer> GetById(string productId);

        IResult Add(Customer customer);

        IResult Update(Customer customer);

        IResult Delete(Customer customer);

        
    }
}
