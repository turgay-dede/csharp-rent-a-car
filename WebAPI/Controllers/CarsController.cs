using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_carService.GetAll());
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            return Ok(_carService.Add(car));
        }

        [HttpGet("getbybrand")]
        public IActionResult GetByBrand(string brandName)
        {
            return Ok(_carService.GetCarsByBrandName(brandName));
        }

        [HttpGet("getbycolor")]
        public IActionResult GetByColorId(string colorName)
        {
            return Ok(_carService.GetCarsByColorName(colorName));
        }

        [HttpGet("getbydetail")]
        public IActionResult GetByCarDetail(int id)
        {
            return Ok(_carService.GetByCarDetails(id));
        }
    }
}
