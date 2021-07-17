using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Result Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult();
            }
            return new ErrorResult();

        }

        public Result Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public DataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public DataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public DataResult<CarDto> GetByCarDetails(int id)
        {
            return new SuccessDataResult<CarDto>(_carDal.GetByCarDetails(id));
        }

        public DataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public DataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public Result Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}
