using System;

namespace Exersice701
{
    class Program
    {
        static void Main(string[] args)
        {
            //newで呼び出して変数に入れた時点で、そのクラスのフィールドがオブジェクトとして入れられる
            //初期値としてフィールドで代入されている値がオブジェクトの中身として入っている
            Vector2D v1 = new Vector2D();
            //v1.X = 1.0; v1.Y = 1.0;
            //v1.Add(1.0, 1.0);

            Console.WriteLine("v1=({0},{1})", v1.X, v1.Y);

            Vector2D v2 = new Vector2D();
            v2.X = 1.0; v2.Y = -1.0;
            Console.WriteLine("v2=({0},{1})", v2.X, v2.Y);

            v1.Add(v2);
            Console.WriteLine("v2=({0},{1})", v1.X, v1.Y);

            v1.Sub(v2);
            Console.WriteLine("v2=({0},{1})", v1.X, v1.Y);

            v1.Mul(2.0);
            Console.WriteLine("v2=({0},{1})", v1.X, v1.Y);

            Console.WriteLine("積：{0}", v1.DotProduct(v2));
        }
    }
}
