using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample203
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用する変数の定義
            int a1 = 2, b1 = 2, c1 = 2, d1 = 2;    // 変数の宣言(1)
            int a2 = 2, b2 = 2, c2 = 2, d2 = 2;    // 変数の宣言(2)
            //  普通の演算による計算と代入
            a1 = a1 + 1;
            b1 = b1 - 1;
            c1 = c1 * 2;
            d1 = d1 / 2;
            //  代入演算による計算
            a2 += 1;    //  a2 = a2 + 1と同じ
            b2 -= 1;    //  b2 = b2 - 1と同じ
            c2 *= 2;    //  c2 = c2 * 2と同じ
            d2 /= 2;    //  d2 = d2 / 2と同じ
            Console.WriteLine("a1={0} b1={1} c1={2} d1={3}", a1, b1, c1, d1);
            Console.WriteLine("a2={0} b2={1} c2={2} d2={3}", a2, b2, c2, d2);
        }
    }
}
