using System;

namespace Sample304
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("サイコロの目：");
            int dice = int.Parse(Console.ReadLine());

            if (dice >=1 && dice <= 6)
            {
                if (dice % 2 == 0)
                {
                    Console.WriteLine("偶数です");
                }
                else
                {
                    Console.WriteLine("奇数です");
                }

            }
            else
            {
                Console.WriteLine("範囲外です");
            }
        }
    }
}
