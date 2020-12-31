using System;
namespace Exersice701
{
    public class Vector2D
    {
        //フィールド値
        //publicにしないと他のクラスから取得できないので注意
        //public double X, Y;


        //変数を返さなくていい場合はvoid
        public void Add(Vector2D v)
        {
            X += v.X;   //このクラス内では元のX(小文字)は大文字のXでの定義に変わっているのでそれに全て変換
            Y += v.Y;
        }

        //変数を返さなくていい場合はvoid
        public void Sub(Vector2D v)
        {
            this.X -= v.X;
            this.Y -= v.Y;
        }

        //変数を返さなくていい場合はvoid
        public void Mul(double k)
        {
            this.X *= k;
            this.Y *= k;
        }

        public double DotProduct(Vector2D v)
        {
            return X * v.X + Y * v.Y;
        }


        public double X
        {
            set; get;
        }

        public double Y
        {
            set; get;
        }
    }
}
