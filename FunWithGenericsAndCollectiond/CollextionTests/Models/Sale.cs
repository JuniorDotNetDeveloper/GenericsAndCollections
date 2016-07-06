using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollextionTests.Models
{

    abstract class Entity
    {
        public int Id { get; set; }
    }
    class Sale : Entity
    {
        public Car car { get; set; }

        public Sale(Customer customer, Car car)
        {

        }
    }
}
