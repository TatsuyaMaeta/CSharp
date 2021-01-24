using System;
namespace SampleEx303
{
    public class Parent
    {
        //子クラスからの上書きの可能性がある場合親クラスにvirtualをつける。
        public virtual void Foo() {
            Console.WriteLine("親クラスのFooメソッド");
        }
    }
}
