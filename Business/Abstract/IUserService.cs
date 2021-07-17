using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        Result Add(User user);
        Result Delete(User user);
        Result Update(User user);
        DataResult<List<User>> GetAll();
        DataResult<User> GetById(int id);
    }
}
