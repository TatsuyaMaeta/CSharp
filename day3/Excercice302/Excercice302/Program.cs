using System;

namespace Excercice302
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字を入力してください：");

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            switch (str1)
            {
                case "hello":
                    Console.WriteLine("GOOD!");
                    break;

                default:
                    Console.WriteLine("hello world Please!!");
                    break;
            }

            switch (str2)
            {
                case "world":
                    Console.WriteLine("GOOD!");
                    break;

                default:
                    Console.WriteLine("hello world Please!!");
                    break;
            }
        }
    }
}
