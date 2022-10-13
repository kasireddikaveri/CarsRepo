using DataLayer.Models;
using DataLayer.Repository.Implementations;
using DataLayer.Repository.Interfaces;
using DataLayerProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerProject.Repository.Implementations
{
    public class DummyGetCarByIdRepository : IGetCarByIdRepository
    {
        private readonly IGetCarsRepository getCarsRepository;

        public DummyGetCarByIdRepository(IGetCarsRepository getCarsRepository)
        {
            this.getCarsRepository = getCarsRepository;
        }

        public Car GetCar(int carId)
        {
            List<Car> cars = getCarsRepository.GetCars();
            //foreach (Car car in cars)
            //{
            //    if (car.Id == carId)
            //    {
            //        return car;
            //    }
            //}

            return cars.Where(a=>a.Id == carId).FirstOrDefault();

            //return new Car();
        }
    }
}
