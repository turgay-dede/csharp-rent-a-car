using Core.Utilities.Results;
using Core.Entities.Concreate;
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
        List<OperationClaim> GetClaims(User user);    
        User GetByMail(string email);
    }
}
