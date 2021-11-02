using Core.DataAccess;
using Entities.Concreate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        CarDto GetByCarDetails(int id);
        List<CarDto> GetAllCarDto();
    }
}
