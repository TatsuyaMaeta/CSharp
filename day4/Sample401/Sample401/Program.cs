using System;

namespace Sample401
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i_max = 3;
            int k_max = 4;

            for (int i = 0; i < i_max; i++)
            {
                for (int k = 1; k < k_max; k++)
                {
                    Console.Write(i + " + " + k + " = " + i + k);
                }
                Console.WriteLine("");
            }
        }
    }
}
