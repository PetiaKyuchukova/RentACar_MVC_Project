using RentACar.Models;
using RentACar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Interfaces
{
    public interface IAddCarService
    {
        Task<Car> AddCar(Car car);
    }
}
