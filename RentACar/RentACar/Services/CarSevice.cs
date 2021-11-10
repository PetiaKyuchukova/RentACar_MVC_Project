using RentACar.DataAccess;
using RentACar.Interfaces;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Services
{
    public class CarSevice: ICarService
    {
        private readonly RentACarDBContext context;
        public CarSevice(RentACarDBContext context)
        {
            this.context = context;
        }
        public async Task<Car> AddCar(Car car)
        {
            await context.Cars.AddAsync(car);
            await context.SaveChangesAsync();

            return car;
        }
    }
}
