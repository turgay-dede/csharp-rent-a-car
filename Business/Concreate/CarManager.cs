using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Concreate
{

    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator), Priority = 1)]
        [CacheRemoveAspect("ICarService.Get")]
        //[SecuredOperation("admin")]
        public Result Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult();
        }

        [CacheRemoveAspect("ICarService.Get")]
        public Result Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public DataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }
        [CacheAspect]
        public DataResult<List<CarDto>> GetAll()
        {
            return new SuccessDataResult<List<CarDto>>(_carDal.GetAllCarDto());
        }
        [CacheAspect]
        public DataResult<CarDto> GetByCarDetails(int id)
        {
            return new SuccessDataResult<CarDto>(_carDal.GetByCarDetails(id));
        }
        [CacheAspect(duration: 1)]
        public DataResult<List<CarDto>> GetCarsByBrandName(string brandName)
        {
            return new SuccessDataResult<List<CarDto>>(_carDal.GetAllCarDto().FindAll(x=>x.BrandName == brandName));
        }
        [CacheAspect]
        public DataResult<List<CarDto>> GetCarsByColorName(string colorName)
        {
            return new SuccessDataResult<List<CarDto>>(_carDal.GetAllCarDto().FindAll(x=>x.ColorName==colorName));
        }

        [ValidationAspect(typeof(CarValidator), Priority = 1)]
        [CacheRemoveAspect("ICarService.Get")]
        public Result Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}
