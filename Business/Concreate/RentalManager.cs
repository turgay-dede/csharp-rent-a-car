using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        [CacheRemoveAspect("IRentalService.Get")]
        public Result Add(Rental rental)
        {
           
            if ( _rentalDal.GetAll(r=>r.CarId==rental.CarId).FindLast(f=>f.CarId==rental.CarId).ReturnDate!=null )
            {
                _rentalDal.Add(rental);
                return new SuccessResult("Araç kiralandı");
            }

            return new ErrorResult("Araç boşta değil");


        }

        [CacheRemoveAspect("IRentalService.Get")]
        public Result Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        [CacheAspect]
        public DataResult<List<RentalDto>> GetAll()
        {
            return new SuccessDataResult<List<RentalDto>>(_rentalDal.GetAllRentalDto());
        }

        [CacheAspect]
        public DataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        [ValidationAspect(typeof(RentalValidator))]
        [CacheRemoveAspect("IRentalService.Get")]
        public Result Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
