﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollextionTests.Models
{
    internal class Garage
    {
        public List<Car> CarList { get; set; }

        public Garage()
        {
            CarList = new List<Car>();
        }
    }
}
