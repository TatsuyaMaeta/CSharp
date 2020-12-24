using System;
using System.Collections;

namespace _26_switch {
    class Program {
        static void Main (string[] args) {
            Console.Write ("1から３の整数を入力してください:");
            int num = int.Parse (Console.ReadLine ());

            switch (num) {
                case 1:
                    Console.WriteLine ("one");
                    break;
                case 2:
                    Console.WriteLine ("two");
                    break;
                case 3:
                    Console.WriteLine ("three");
                    break;

                default:
                    Console.WriteLine("不適切！");
                    break;
            }
        }
    }
}