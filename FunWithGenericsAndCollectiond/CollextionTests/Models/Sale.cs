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
        public Customer CustomerId { get; set; }
        public Car CarId { get; set; }


    }
}
