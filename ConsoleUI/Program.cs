using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Entities.Concreate.Rental { CarId = 1, CustomerId = 2, RentDate = DateTime.Now });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }else
            {
                Console.WriteLine(result.Message);
            }
            //foreach (var r in rentalManager.GetAll().Data)
            //{
            //    Console.WriteLine(r.CarId);
            //}
          
            

          
            
            //UserTest(userManager);
            // BrandTest(brandManager);
            //CarTest(carManager);
        }

        private static void UserTest(UserManager userManager)
        {
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void BrandTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByBrandId(2).Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
