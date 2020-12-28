using System;

namespace Exercise401
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r1 = new Random();
            //Random num2 = new Random();

            int num1 = r1.Next(1, 11);
            int num2 = r1.Next(1, 11);

            Console.WriteLine("a=" + num1 + " b=" + num2 +" = "+ (num1+num2) );
            int answer = int.Parse(Console.ReadLine());

            if (answer == num1+num2)
            {
                Console.WriteLine("正解");
            }
            else
            {
                Console.WriteLine("まちがい");
            }


            Console.WriteLine("数値を入力してください");
            int num = int.Parse( Console.ReadLine());
            int count = 1;

            while (count < num)
            {
                if (num % count == 0 && num == count)
                {
                    Console.Write(count);
                }
                else if (num % count == 0 )
                {
                    Console.Write(count + " ");
                }

                count++;
            }




            

            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine(i+"Hello World!");
            }
        }
    }
}
