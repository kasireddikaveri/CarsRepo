﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerProject.Repository.Interfaces
{
    public interface IAddNewCarRepository
    {
        void Add(Car car);
    }
}
