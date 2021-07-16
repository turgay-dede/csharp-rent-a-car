using Business.Abstract;
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

        public void Add(Rental rental)
        {
            _rentalDal.Add(rental);
        }

        public void Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public Rental GetById(int id)
        {
            return _rentalDal.Get(r => r.Id == id);
        }

        public void Update(Rental rental)
        {
            _rentalDal.Update(rental);
        }
    }
}
