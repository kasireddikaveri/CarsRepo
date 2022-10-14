using DataLayer.Models;
using DataLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Implementations
{
    public class InMemoryCarsRepositoy : IGetCarsRepository
    {
        public List<Car> GetCars()
        {
            var cars = new List<Car> {
                new Car { Id=1, Brand="Maruti", Model="Brezza", Cost=10, ImageUrl="https://dummyimage.com/600x400/d620d6/fff&text=Brezza", Description = "desc1"},
                new Car { Id=2, Brand="Maruti", Model="Baleno", Cost=8 , ImageUrl="https://dummyimage.com/600x400/d620d6/fff&text=Baleno", Description = "desc2"},
                new Car { Id=3, Brand="Kia", Model="Carnival", Cost=8 , ImageUrl="https://dummyimage.com/600x400/d620d6/fff&text=Carnival", Description = "desc3"},
            };           

            cars = cars.Where(a=>a.Model != "Maruti").ToList();

            return cars;
        }
    }
}
