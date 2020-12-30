using System;

namespace Sample602
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int a = 1, b = 2, c = 3;

            int ans1 = calc.Add(a, b);
            int ans2 = calc.Add(a, b, c);

            Console.WriteLine(ans1);
            Console.WriteLine(ans2);

        }
    }
}
