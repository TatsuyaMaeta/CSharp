using System;

namespace Excercice201
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = 1.1, a2 = 2.1;
            double b1 = 3.7, b2 = 6.25;
            double c1 = 5.0, c2 = 2.1;
            double d1 = 2.2, d2 = 0.1;

            int f1 = 2;
            double f2 = 1.34, f3 = 2.12, f4 = 3.4, f5 = 10.0;
            double sum = f1 * (f2 + f3) + f4 / f5;

            Console.WriteLine("{0} + {1} = {2}",a1, a2, a1 + a2);
            Console.WriteLine("{0} - {1} = {2}", b1, b2, b1 - b2);
            Console.WriteLine("{0} * {1} = {2}", c1, c2, c1 * c2);
            Console.WriteLine("{0} / {1} = {2}", d1, d2, d1 / d2);

            Console.WriteLine("{0} * ({1} + {2}) + {3} / {4} = {5}",
                f1, f2, f3, f4, f5, sum);
            //2行で分割しても大丈夫
        }
    }
}
