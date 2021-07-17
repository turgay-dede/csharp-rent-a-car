using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Result Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public Result Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public DataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public DataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(cl => cl.Id == colorId));
        }

        public Result Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }
    }
}
