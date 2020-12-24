using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise201
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} + {1} = {2}", 1.1, 2.1, 1.1 + 2.1);
            Console.WriteLine("{0} - {1} = {2}", 3.7, 6.25, 3.7 - 6.25);
            Console.WriteLine("{0} * {1} = {2}", 5.0, 2.1, 5.0 * 2.1);
            Console.WriteLine("{0} / {1} = {2}", 2.2, 0.1, 2.1 / 0.1);
            Console.WriteLine("{0} * ({1} + {2}) + {3} / {4} = {5}", 
                2 , 1.34 , 2.12 , 3.4 , 10.0 , 2 * (1.34 + 2.12) + 3.4 / 10.0);
        }
    }
}
