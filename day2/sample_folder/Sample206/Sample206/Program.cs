using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample206
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER = 100;
            const string STRING = "Hoge";
            Console.WriteLine(NUMBER);
            Console.WriteLine(STRING);
            //  constがついた変数は値を変えられない
            NUMBER = 100;
            STRING = "fuga";
        }
    }
}
