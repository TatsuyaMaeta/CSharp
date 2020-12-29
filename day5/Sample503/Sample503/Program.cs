using System;

namespace Sample503
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 5, 4, 3, 2, 1 };
            string[] str = { "ABC", "DEF", "GHI" };

            int max = num.Length; 
            for (int i = 0; i < max; i++)
            {
                Console.Write(num[i] + " ");
            }

            Console.WriteLine();

            int max2 = str.Length;
            for (int i = 0; i < max2; i++)
            {
                Console.Write(str[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Hello World!");
        }
    }
}
