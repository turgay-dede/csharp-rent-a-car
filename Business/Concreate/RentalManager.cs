﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
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

        public Result Add(Rental rental)
        {
           
            if ( _rentalDal.GetAll(r=>r.CarId==rental.CarId).FindLast(f=>f.CarId==rental.CarId).ReturnDate!=null )
            {
                _rentalDal.Add(rental);
                return new SuccessResult("Araç kiralandı");
            }

            return new ErrorResult("Araç boşta değil");


        }

        public Result Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }


        public DataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public DataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public Result Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
