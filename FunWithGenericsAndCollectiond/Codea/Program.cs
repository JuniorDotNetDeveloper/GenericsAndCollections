using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 10;
            b = 10;
            c = a^b;
            //Console.WriteLine(a^b);
            //Console.WriteLine(a^a);
            //Console.WriteLine(a^c);

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.Read();
        }
    }
}
