using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerProject
{
    public class CarsDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}
