using DataLayer.Models;
using DataLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerProject.Repository.Implementations
{
    public class GetCarsRepository : IGetCarsRepository
    {
        private readonly CarsDBContext database;

        public GetCarsRepository(CarsDBContext database)
        {
            this.database = database;
        }
        public List<Car> GetCars()
        {
            List<Car> cars = database.Cars.ToList();

            return cars;
            
        }
    }
}
