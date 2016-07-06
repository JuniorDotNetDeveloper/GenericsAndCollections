using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollextionTests.Models
{
    enum CarBody : byte
    {
        Hatchback,
        Sedan,
        Universal,
        Minivan
    }
    class Car : IEqualityComparer<Car>
    {
        public int CarId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public CarBody ModelBody { get; set; }
        public decimal Price { get; set; }
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

        public bool Equals(Car x, Car y)
        {
            return  x.Model.Equals(y.Model) 
                    && x.Manufacturer.Equals(y.Manufacturer)
                    && x.ModelBody.Equals(y.ModelBody);
        }

        public int GetHashCode(Car obj)
        {
            return obj.Model.GetHashCode() ^ obj.ModelBody.GetHashCode() ^ obj.Manufacturer.GetHashCode();
        }
    }
}
