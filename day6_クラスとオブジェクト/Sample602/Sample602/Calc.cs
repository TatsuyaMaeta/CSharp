using System;
namespace Sample602
{
    public class Calc
    {
        public int Add(int a,int b) {
            Console.WriteLine("haaaa");
            return a + b;
        }

        //6行目のメソッドと同じ名前だが、引数と戻り値が異なる為、重複していてもエラーにならない
        public int Add(int a, int b, int c){

            return a + b + c;
        }


        
    }
}
