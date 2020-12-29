using System;

namespace Sample505
{
    class Program
    {
        static void Main(string[] args)
        {
            int max1 = 3;
            int max2 = 4;
            int[,] dbl_arr = new int[max1, max2];
            
            int x, y;

            //値の代入
            for (x = 0; x < max1; x++)
            {
                for (y = 0; y < max2; y++)
                {
                    dbl_arr[x, y] = x + y;
                }
            }

            //値の出力
            for (x = 0; x < max1; x++)
            {
                for (y = 0; y < max2; y++)
                {
                    Console.Write("dbl_arr[{0},{1}] = {2}  ", x, y, dbl_arr[x, y]);
                }
                Console.WriteLine();
            }

        }
    }
}
