using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        Result Add(Brand brand);
        Result Delete(Brand brand);
        Result Update(Brand brand);
        DataResult<List<Brand>> GetAll();
        DataResult<Brand> GetById(int brandId);
    }
}
