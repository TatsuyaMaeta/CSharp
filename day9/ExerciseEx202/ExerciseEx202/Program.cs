using System;

namespace ExerciseEx202
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            string[] array = line.Split(' ');
            int a = 0;
            int b = 0;
            if (array.Length <= 2)
            {
                a = int.Parse(array[0]);
                b = int.Parse(array[1]);
            }

            //Numeric n = new Numeric();

            int ans = Numeric.Max(a, b);

            Console.WriteLine("aの{0}とbの{1}を比較すると最大値は{2}です",
                                a,b,ans);

        }
    }
}
