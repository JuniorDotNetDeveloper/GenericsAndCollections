using CollextionTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollextionTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(new Engine(EngineType.Diesel, 170, 2198, 250), "Mercedes-Benz", "E220");
            Car car2 = new Car(new Engine(EngineType.Diesel, 200, 2498, 400), "Audi", "A6");
            Car car3 = new Car(new Engine(EngineType.Benzin, 140, 1898, 260), "BMW", "320");
            Car car4 = new Car(new Engine(EngineType.Benzin, 370, 2198, 450), "Ford", "Focus");

        }
    }
}
