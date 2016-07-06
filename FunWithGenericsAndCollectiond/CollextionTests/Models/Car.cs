using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollextionTests.Models
{
    class Car
    {
        public int CarId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public DateTime FabrikDate { get; set; }
        public DateTime? FirstRegistration { get; set; }
        public string Description { get; set; }


        public Car(Engine engine, string manufacturer, string model)
        {
            Engine = engine;
            Manufacturer = manufacturer;
            Model = model;
            FabrikDate = DateTime.Now;
        }

    }
}
