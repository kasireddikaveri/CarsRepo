using DataLayer.Models;
using DataLayerProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerProject.Repository.Implementations
{
    public class AddNewCarRepository : IAddNewCarRepository
    {
        private readonly CarsDBContext database;

        public AddNewCarRepository(CarsDBContext database)
        {
            this.database = database;
        }

        public void Add(Car car)
        {
            //Add it the db
            database.Cars.Add(car); 
            database.SaveChanges();
        }
    }
}
