using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample204
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b, c, d;
            a = (int)1.23;  //  キャストで代入
            b = 1.23;
            c = 10;         //  キャストなしで代入
            d = (double)c;  //  キャストありで代入
            Console.WriteLine("a={0} b={1} c={2} d={3}", a, b, c, d);
        }
    }
}
