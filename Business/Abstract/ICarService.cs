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
        DataResult<List<CarDto>> GetAll();
        DataResult<Car> GetById(int id);
        DataResult<List<CarDto>> GetCarsByBrandName(string brandName);
        DataResult<List<CarDto>> GetCarsByColorName(string colorName);
        DataResult<CarDto> GetByCarDetails(int id);
    }
}
