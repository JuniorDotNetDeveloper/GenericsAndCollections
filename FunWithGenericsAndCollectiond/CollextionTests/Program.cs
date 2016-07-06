using CollextionTests.Helpers;
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
            List<Car> carList = new List<Car>()
            { };
            Car car1 = new Car(new Engine(EngineType.Diesel, 170, 2198, 250), "Mercedes-Benz", "E220");
            Car car7 = new Car(new Engine(EngineType.Diesel, 170, 2198, 250), "Mercedes-Benz", "E220");

            Car car2 = new Car(new Engine(EngineType.Diesel, 200, 2498, 400), "Audi", "A6");
            Car car3 = new Car(new Engine(EngineType.Benzin, 140, 1898, 260), "BMW", "320");
            Car car4 = new Car(new Engine(EngineType.Benzin, 370, 2198, 450), "Ford", "Focus");

            Customer cust1 = new Customer("Suruceanu", "Ion");
            Customer cust2 = new Customer("Andronic", "Costea");
            Customer cust3 = new Customer("Moga", "Ion");
            Customer cust4 = new Customer("Cross", "Tony");

            Dictionary<Car, Customer> carCustomerDictionary = new Dictionary<Car, Customer>(new CarEqualityComparer());
            carCustomerDictionary.Add(car1, cust1);
            carCustomerDictionary.Add(car2, cust2);
            carCustomerDictionary.Add(car3, cust3);
            carCustomerDictionary.Add(car4, cust4);
            //carCustomerDictionary.Add(car7, cust4);


            //Array.Sort(carList.ToArray(), (_, __) => _.Manufacturer.CompareTo(__.Manufacturer));

            Car[] calist = carCustomerDictionary.Keys.ToArray();
            Array.Sort(carCustomerDictionary.Keys.ToArray(), (x, y) => x.Model.CompareTo(y.Model));

            foreach (var item in carCustomerDictionary.Keys)
            {
                Console.WriteLine(item);
            }

            //carCustomerDictionary.OrderBy(x => x.Key, (x, y) => { return x.Price.CompareTo(y.Price); });

            Console.WriteLine(carCustomerDictionary[car1].FirstName);
            var car = carCustomerDictionary.FirstOrDefault(x => x.Value.FirstName == "Ion").Key;
            
            Console.ReadLine();

        }
    }
}
