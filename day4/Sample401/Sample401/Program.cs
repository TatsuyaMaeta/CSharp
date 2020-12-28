using System;

namespace Sample401
{
    class Program
    {
        static void Main(string[] args)
        {

            //while と Do Whileの違い
            //while:もし１回目から条件式がfalseだとしたら計算は実行されない
            //Do while:最低１回は計算処理は実行される


            //304
            int cnt = 0;

            while (cnt < 5)
            {
                Console.WriteLine(cnt);
                cnt++;
            }



            Console.WriteLine("※※※※※※※※※※※※※※※※※※※※※※※※");

            int i_max = 3;
            int k_max = 4;

            for (int i = 1; i < i_max; i++){

                for (int k = 1; k < k_max; k++){
                    Console.Write(i + " + " + k + " = " + (i + k) +" / ");
                }
                Console.WriteLine("");
            }
        }
    }
}
