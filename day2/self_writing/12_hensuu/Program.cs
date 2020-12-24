using System;

namespace day3_hensuu {
    class Program {
        static void Main (string[] args) {
            int a;
            double b, c, d;
            a = (int) 1.23; //キャストで代入
            b = 1.23;
            c = 10;
            d = (double)c;

            Console.WriteLine ("a={0} b={1} c={2} d={3}", a, b, c, d);

            Console.WriteLine ("-----------------------\n");

            //sample203
            int a1 = 2, b1 = 2, c1 = 2, d1 = 2;
            int a2 = 2, b2 = 2, c2 = 2, d2 = 2;

            a1 = a1 + 1;
            b1 = b1 - 1;
            c1 = c1 * 2;
            d1 = d1 / 2;

            a2 += 1;
            b2 -= 1;
            c2 *= 2;
            d2 /= 2;

            Console.WriteLine ("a1={0} b1={1} c1={2} d1={3}", a1, b1, c1, d1);
            Console.WriteLine ("a2={0} b2={1} c2={2} d2={3}", a2, b2, c2, d2);

            Console.WriteLine ("-----------------------\n");

            int a; //変数の宣言
            int b = 3; //初期値を変数に設定
            double n = 2.0;
            int add, sub; //複数の変数の宣言
            double ave; //int以外の型の宣言

            a = 6;
            add = a + b;
            sub = a - b;
            ave = (a + b) / n;

            Console.WriteLine ("add: {0} + {1} = {2}", a, b, add);
            Console.WriteLine ("sum: {0} - {1} = {2}", a, b, sub);
            Console.WriteLine ("average: {0} と {1} の平均値 {2}\n", a, b, ave);

            Console.WriteLine ("-----------------------\n");

        }
    }
}