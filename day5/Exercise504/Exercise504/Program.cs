using System;

namespace Exercise504
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[9, 9];
            int arr_x_l = array.GetLength(0);
            int arr_y_l = array.GetLength(0);

            for (int x = 0; x < arr_x_l; x++)
            {
                for (int y = 0; y < arr_y_l; y++)
                {
                    array[x, y] = (x + 1) * (y + 1);

                    Console.Write("array[{0},{1}]={2}  ",
                                      x + 1, y + 1, (x+1) * (y+1));
                }

                Console.WriteLine();
            }
            
            
        }
    }
}
