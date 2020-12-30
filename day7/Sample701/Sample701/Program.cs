using System;

namespace Sample701
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;              //Personクラスを参照するために
            p1 = new Person();      //Personクラスのオブジェクトをp1に代入
            p1.Name = "山田太郎";    //名前を代入
            p1.Age = 33;            //年齢を代入
            p1.ShowAgeAndName();    //PersonクラスのメソッドであるShowAgeAndName()を実行

            Console.WriteLine("Hello World!");

            //クラスのフィールド値は基本的には隠蔽(カプセル化)させるのが普通
            //外部からのアクセスが容易だと情報のセキュリティが低下する為
            //アクセスするためにプロパティを経由して利用する
        }
    }
}
