using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Delete(User user);
        void Update(User user);
        List<User> GetAll();
        User GetById(int id);
    }
}
