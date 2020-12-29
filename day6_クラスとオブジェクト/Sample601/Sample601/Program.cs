using System;

namespace Sample601
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;              //Personクラスを参照するために
            p1 = new Person();      //Personクラスのオブジェクトをp1に代入
            p1.name = "山田太郎";    //名前を代入
            p1.age = 33;            //年齢を代入
            p1.ShowAgeAndName();    //PersonクラスのメソッドであるShowAgeAndName()を実行

            Console.WriteLine("Hello World!");
        }
    }
}
