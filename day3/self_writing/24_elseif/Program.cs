using System;

namespace _15_mojiretu {
    class Program {
        static void Main (string[] args) {
            Console.Write ("1から３の整数を入力してください:");
            int num = int.Parse (Console.ReadLine ());

            if (num == 1) {
                Console.WriteLine ("enter num = 1");
            } else if (num == 2) {
                Console.WriteLine ("enter num = 2");
            } else if (num == 3) {
                Console.WriteLine ("enter num = 3");
            } else {
                Console.WriteLine ("それ以外です");
            }
        }

    }
}