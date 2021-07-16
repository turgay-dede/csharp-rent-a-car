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
            foreach (var r in rentalManager.GetAll())
            {
                Console.WriteLine(r.CarId);
            }
          
            

          
            
            //UserTest(userManager);
            // BrandTest(brandManager);
            //CarTest(carManager);
        }

        private static void UserTest(UserManager userManager)
        {
            foreach (var user in userManager.GetAll())
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void BrandTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
