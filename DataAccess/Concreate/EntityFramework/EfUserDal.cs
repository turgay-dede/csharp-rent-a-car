using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework.Contexts;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,RentACarContext>,IUserDal
    {
    }
}
