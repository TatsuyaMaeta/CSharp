using System;
namespace Sample701
{
    public class Person
    {
        //名前フィールド
        private string name = "";

        //年齢フィールド
        private int age = 0;

        public void ShowAgeAndName()
        {
            Console.WriteLine("名前:{0} 年齢:{1}", name, age);
        }

        public void SetAgeAndName(string name, int age)
        {
            //this = 自分自身のインスタンスのこと
            this.name = name;
            this.age = age;
        }

        //以下の設定をプロパティと呼ぶ
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}
