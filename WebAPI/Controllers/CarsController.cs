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

        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int id)
        {
            return Ok(_carService.GetCarsByBrandId(id));
        }
    }
}
