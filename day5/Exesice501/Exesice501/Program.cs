using System;

namespace Exesice501
{
    class Program
    {
        static void Main(string[] args)
        {

            int max = 10;
            int[] num_array = new int[max];

            for (int i = 0; i < num_array.Length; i++)
            {
                num_array[i] = i + 1;
            }

            for (int i = 0; i < num_array.Length; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, num_array[i]);
            }
        }
    }
}
