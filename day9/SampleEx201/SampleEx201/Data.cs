using System;
namespace SampleEx201
{
    public class Data
    {
        //クラスを生成するまでもないけど
        //そのクラスにあるフィールドやメソッドを使いたいことがある場合のために
        //staticをつけて使えるようにする

        //static = 静的なフィールド
        //インスタンスを生成せずに使用できる
        //クラスの中でフィールド、メソッド共に１つは割り振りできる
        private static int num = 0;

        private int id;

        //コンストラクタ(ID付き)
        public Data(int id)
        {
            this.id = id;
            num++;
            Console.WriteLine("値：{0}  数：{1}", id, num);
        }

        public static void ShowNumber()
        {
            Console.WriteLine("Dataオブジェクトの数:{0}", num);
        }
    }
}
