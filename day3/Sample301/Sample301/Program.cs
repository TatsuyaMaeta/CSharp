using System;

namespace Sample301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数値を入力");
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("入力値の {0} は整数です",a);
            }
            else if (a == 0)
            {
                Console.WriteLine("入力値の {0} は0です", a);
            }
            else
            {
                Console.WriteLine("入力値の {0} は整数ではありません", a);
            }
        }
    }
}
