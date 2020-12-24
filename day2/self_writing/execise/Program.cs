using System;

namespace _15_mojiretu {
    class Program {
        static void Main (string[] args) {
            double a1 = 1.1, a2 = 2.1, a3;
            double b1 = 3.7, b2 = 6.25, b3;
            double c1 = 5.0, c2 = 2.1, c3;
            double d1 = 2.2, d2 = 0.1, d3;
            double e1 = 2, e2 = 1.34, e3 = 2.12, e4 = 3.4, e5 = 10.0, e6;

            a3 = a1 + a2;
            b3 = b1 - b2;
            c3 = c1 * c2;
            d3 = d1 / d2;
            e6 = e1 * (e2 + e3) + e4 / e5;

            Console.WriteLine ("a: {0} + {1} = {2}", a1, a2, a3);
            Console.WriteLine ("b: {0} - {1} = {2}", b1, b2, b3);
            Console.WriteLine ("c: {0} * {1} = {2}", c1, c2, c3);
            Console.WriteLine ("d: {0} / {1} = {2}", d1, d2, d3);
            Console.WriteLine ("e: {0} * ({1} + {2}) + {3} / {4} = {5}", 
                e1, e2, e3, e4, e5, e6);

        }
    }
}