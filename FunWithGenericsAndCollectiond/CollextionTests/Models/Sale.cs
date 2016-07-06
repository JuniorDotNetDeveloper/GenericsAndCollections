using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollextionTests.Models
{
    class Sale
    {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }

        public Sale(Customer customer, Car car)
        {

        }
    }
}
