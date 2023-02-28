using DataLayer.Models;
using DataLayerProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerProject.Repository.Implementations
{
    public class UpdateCar : IUpdateCar
    {
        private readonly CarsDBContext carsDBContext;

        public UpdateCar(CarsDBContext carsDBContext)
        {
            this.carsDBContext = carsDBContext;
        }

        public void Update(Car car)
        {
            carsDBContext.Cars.AddOrUpdate(car);
            carsDBContext.SaveChanges();
        }
    }
}
