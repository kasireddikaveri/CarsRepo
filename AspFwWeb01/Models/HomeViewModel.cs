using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspFwWeb01.Models
{
    public class HomeViewModel
    {
        public List<Car> Cars { get; set; }
        public string Message { get; set; }
    }

    
}