using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericsAndCollectiond
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericStore<int> store = new GenericStore<int>(20);
            store.Set(0, 5);
            store.Set(1, 15);
            store.Set(2, 25);
            store.Set(3, 35);
            store.Set(4, 45);
            store.Set(5, 55);

            store.ChangeValues(0, 5);

            Console.WriteLine(store.Get(0));
            Console.WriteLine(store.Get(5));

            Console.ReadLine();
        }


    }
}
