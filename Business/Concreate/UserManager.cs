using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public Result Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public Result Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public DataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public DataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        public Result Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
