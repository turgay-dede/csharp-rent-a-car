using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        Result Add(Color color);
        Result Delete(Color color);
        Result Update(Color color);
        DataResult<List<Color>> GetAll();
        DataResult<Color> GetById(int colorId);
    }
}
