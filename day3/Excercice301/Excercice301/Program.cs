using System;

namespace Excercice301
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = 0;
            Console.Write("tempの値を入力してください：");

            temp = double.Parse(Console.ReadLine());

            if (temp == 0.0)
            {
                Console.WriteLine("temp is "+ temp +",zero");
            }
            else if (temp < 0.0)
            {
                Console.WriteLine("temp is " + temp + ",minus");
            }
            else if (temp > 0.0)
            {
                Console.WriteLine("temp is " + temp + ",plus");
            }
        }
    }
}
