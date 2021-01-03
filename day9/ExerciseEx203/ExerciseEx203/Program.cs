using System;

namespace ExerciseEx203
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = int.Parse(Console.ReadLine());
            double root_num = 0;

            if (num >= 0)
            {
                root_num = Math.Sqrt(num);
            }
            else
            {
                Console.WriteLine("正の数を入力してください");
            }

            Console.WriteLine("{0}の平方根は{1}です",num,root_num);
        }
    }
}
