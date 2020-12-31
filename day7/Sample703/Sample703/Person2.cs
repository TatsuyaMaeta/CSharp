using System;
namespace Sample703
{
    public class Person2
    {

        //  情報の設定
        public void SetAgeAndName(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //  情報の表示（メソッド）
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", Name, Age);
        }

        //  情報の設定
        public string Name
        {
            private set; get;
        }

        //  情報の設定
        public int Age
        {
            set; get;
        }
    }
}
