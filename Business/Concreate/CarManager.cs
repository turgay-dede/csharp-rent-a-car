﻿using Business.Abstract;
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

        public void Add(Car car)
        {
            if (car.Name.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public CarDto GetByCarDetails(int id)
        {
            return _carDal.GetByCarDetails(id);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}