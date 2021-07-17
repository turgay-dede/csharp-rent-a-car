using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        Result Add(Rental rental);
        Result Delete(Rental rental);
        Result Update(Rental rental);
        DataResult<List<Rental>> GetAll();
        DataResult<Rental> GetById(int id);
    }
}
