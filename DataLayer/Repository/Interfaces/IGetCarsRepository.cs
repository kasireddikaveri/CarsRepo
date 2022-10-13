using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Interfaces
{
    public interface IGetCarsRepository
    {
        List<Car> GetCars();
    }
}
