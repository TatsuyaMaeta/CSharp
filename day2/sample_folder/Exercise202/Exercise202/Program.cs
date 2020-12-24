using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise202
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int型変数a,b,cを用意しなさい。
            int a, b, c;
            //  aに2を、bに3を代入しなさい。
            a = 2;
            b = 3;
            //  aとbを足した値を表示しなさい。
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //  cに、aからbを引いた値を代入しなさい。
            c = a - b;
            //  cを表示しなさい。
            Console.WriteLine(c);
        }
    }
}
