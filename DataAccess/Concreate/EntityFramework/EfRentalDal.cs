using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework.Contexts;
using Entities.Concreate;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDto> GetAllRentalDto()
        {
            using (RentACarContext context = new RentACarContext())
            {
                
                 var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join cs in context.Customers
                             on r.CustomerId equals cs.Id
                             join u in context.Users
                             on cs.UserId equals u.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id

                              


                              select new RentalDto
                             {
                                 Id = r.Id,   
                                 BrandName = b.BrandName,
                                 CustomerName = u.FirstName + " " + u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
