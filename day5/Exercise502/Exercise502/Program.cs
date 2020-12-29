using System;

namespace Exercise502
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] double_arr = new double[3];
            Double[] double_num_arr = { 0.2, 1.4, -0.8 };

            int arr_length = double_arr.Length;
            int num_arr_length = double_num_arr.Length;

            for (int i = 0; i < arr_length; i++)
            {
                double_arr[i] = double_num_arr[i];
            }

            for (int i = 0; i < arr_length; i++)
            {
                Console.WriteLine("double_arr[{0}] = {1}", i, double_arr[i]);
            }

        }
    }
}
