using CollextionTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollextionTests.Helpers
{
    class CarEqualityComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car x, Car y)
        {
            return x.Model.Equals(y.Model)
                    && x.ModelBody.Equals(y.ModelBody)
                    && x.Manufacturer.Equals(y.Manufacturer);
        }

        public int GetHashCode(Car obj)
        {
            return obj.Model.GetHashCode()
        }
    }
}
