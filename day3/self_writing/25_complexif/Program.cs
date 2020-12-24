using System;

namespace _25_complexif {
    class Program {
        static void Main (string[] args) {
            Console.Write ("サイコロの目 : ");

            int dice = int.Parse (Console.ReadLine ());

            if (1 <= dice && dice <= 6) 
            {
                if (dice == 2 || dice == 4 || dice == 6) {
                    Console.WriteLine ("偶数の目です");
                } else {
                    Console.WriteLine ("奇数の目です");
                }
            }
            else
            {
                Console.WriteLine("サイコロの目以外の数値です");
            }
        }
    }
}