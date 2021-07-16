using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryCarDal 
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
           {
               new Car {Id=1,BrandId=1,ColorId=1,DailyPrice=100,ModelYear="2021",Description="1. araba"},
               new Car {Id=1,BrandId=2,ColorId=2,DailyPrice=90,ModelYear="2020",Description="2. araba"},
               new Car {Id=1,BrandId=3,ColorId=3,DailyPrice=80,ModelYear="2019",Description="3. araba"},
               new Car {Id=1,BrandId=4,ColorId=4,DailyPrice=70,ModelYear="2018",Description="4. araba"},
               new Car {Id=1,BrandId=5,ColorId=5,DailyPrice=60,ModelYear="2017",Description="5. araba"},
           };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            Car deleteToCar = _cars.SingleOrDefault(c=>c.Id==id);
            _cars.Remove(deleteToCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.ModelYear = car.ModelYear;
            updateToCar.Description = car.Description;
        }
    }
}
