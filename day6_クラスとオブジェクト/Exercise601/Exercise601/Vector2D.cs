using System;
namespace Exercise601
{
    public class Vector2D
    {
        //フィールド値
        //publicにしないと他のクラスから取得できないので注意
        public double x ,y ;

        //変数を返さなくていい場合はvoid
        public void Add(Vector2D v)
        {
            this.x += v.x;
            this.y += v.y;
        }

        //変数を返さなくていい場合はvoid
        public void Sub(Vector2D v)
        {
            this.x -= v.x;
            this.y -= v.y;
        }

        //変数を返さなくていい場合はvoid
        public void Mul(double k)
        {
            this.x *= k;
            this.y *= k;
        }

        public double DotProduct(Vector2D v)
        {
            return x * v.x + y * v.y;
        }
    }
}
