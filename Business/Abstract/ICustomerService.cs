using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        Result Add(Customer customer);
        Result Delete(Customer customer);
        Result Update(Customer customer);
        DataResult<List<Customer>> GetAll();
        DataResult<Customer> GetById(int id);
    }
}
