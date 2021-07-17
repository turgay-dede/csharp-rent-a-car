using Core.Utilities.Results;
using Entities.Concreate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        Result Add(Car car);
        Result Delete(Car car);
        Result Update(Car car);
        DataResult<List<Car>> GetAll();
        DataResult<Car> GetById(int id);
        DataResult<List<Car>> GetCarsByBrandId(int brandId);
        DataResult<List<Car>> GetCarsByColorId(int colorId);
        DataResult<CarDto> GetByCarDetails(int id);
    }
}
