using Microsoft.AspNetCore.Mvc;
using RentACar.Interfaces;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Controllers
{
    [ApiController]
    [Route("api/AddCar")]
    public class CarController : ControllerBase
    {
        private readonly ICarService addCarService;
        public CarController(ICarService addCarService)
        {
            this.addCarService = addCarService;
        }

        [HttpPost]
        public async Task AddCar([FromBody] Car car) => await addCarService.AddCar(car);
    }
}
