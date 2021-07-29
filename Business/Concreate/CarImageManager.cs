using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Concreate
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file,CarImage carImage)
        {
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;

            _carImageDal.Add(carImage);
            return new SuccessResult("Resim eklendi");
        }

        public IResult Delete(CarImage carImage)
        {
            FileHelper.Delete(carImage.ImagePath);

            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(x => x.CarId == carId));
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            var oldPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _carImageDal.Get(p => p.Id == carImage.Id).ImagePath;

            carImage.ImagePath = FileHelper.Update(oldPath, file);
            carImage.Date = DateTime.Now;

            _carImageDal.Update(carImage);
            return new SuccessResult();
        }
    }
}
