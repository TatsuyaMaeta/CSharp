using System;

namespace Sample702
{
    class Program
    {
        static void Main(string[] args)
        {
            Access a = new Access();
            //a.read_Data1はデータを受け取る用の為、入力することはできない
            //a.read_Data1 = 1;
            a.write_Data2 = 2;
            a.ShowDatas();
            Console.WriteLine("a.data1 = {0}", a.read_Data1);

            //a.write_Data2はデータを入れて渡す専用な為、出力用に使用できない
            //Console.WriteLine("a.data2 = {0}", a.write_Data2);
        }
    }
}
