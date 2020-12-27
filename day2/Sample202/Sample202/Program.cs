using System;

namespace Sample202
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;      
            int b = 3;
            int add, sub;           //同時に宣言が可能
            double avg;

            a = 2;
            add = a + b ;
            sub = a - b ;
            avg = (a + b) / 2.0;

            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0} と {1} の平均は {2}", a, b, avg);
           
        }
    }
}
