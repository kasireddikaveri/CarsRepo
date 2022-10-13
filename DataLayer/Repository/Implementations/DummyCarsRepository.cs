using DataLayer.Models;
using DataLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Implementations
{
    public class DummyCarsRepository : IGetCarsRepository
    {
        public List<Car> GetCars()
        {
            var cars = new List<Car> {
                new Car {Brand="Maruti", Model="../Content/Images/Cars/001.jpg", Cost=10},
                new Car { Brand="Maruti", Model="../Content/Images/Cars/001.jpg", Cost=8 },
                new Car { Brand="Kia", Model="../Content/Images/Cars/001.jpg", Cost=8 }
            };

            cars.Sort();

            cars = cars.Where(a=>a.Model != "Maruti").ToList();

            return cars;
        }
    }
}
