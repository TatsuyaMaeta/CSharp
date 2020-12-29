using System;

namespace Exsercise503
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int[] array = new int[10];
            Random i_rndm = new Random();

                         //sum,ave,min,max
            int[] number = { 0, 0, 101, 0 };
            //int ave = 0;
            //int min = 0;
            //int max = 0;

            Console.WriteLine("array.Length = {0}", array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i_rndm.Next(1, 101);
                //Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                number[0] += array[i];

                Console.WriteLine("array[{0}] = {1}", i, array[i]);

                //min
                if (number[2] > array[i])
                {
                    number[2] = array[i];
                }

                //max
                if (number[3] < array[i])
                {
                    number[3] = array[i];
                }


            }

            number[1] = number[0] / array.Length;
            Console.WriteLine("sum = {0}", number[0]);
            Console.WriteLine("ave = {0}", number[1]);
            Console.WriteLine("min = {0}", number[2]);
            Console.WriteLine("max = {0}", number[3]);
        }
    }
}
