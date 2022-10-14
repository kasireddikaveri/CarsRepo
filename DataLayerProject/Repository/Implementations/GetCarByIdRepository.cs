using DataLayer.Models;
using DataLayerProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerProject.Repository.Implementations
{
    public class GetCarByIdRepository : IGetCarByIdRepository
    {
        private readonly CarsDBContext database;

        public GetCarByIdRepository(CarsDBContext database)
        {
            this.database = database;
        }

        public Car GetCar(int carId)
        {
           return database.Cars.Where(a=>a.Id == carId).FirstOrDefault();
        }
    }
}
