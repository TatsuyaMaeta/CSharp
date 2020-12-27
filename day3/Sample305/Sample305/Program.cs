using System;

namespace Sample305
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1~3を入力してください：");

            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("two");
                    break;

                case 3:
                    Console.WriteLine("three");
                    break;

                default:
                    break;
            }
        }
    }
}
