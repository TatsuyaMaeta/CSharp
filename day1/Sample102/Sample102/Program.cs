using System;

namespace Sample102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(12345);

            //writeだと行末に改行の内容が含まれない
            Console.Write("Hello World!");
            Console.WriteLine("Unity");
        }
    }
}
