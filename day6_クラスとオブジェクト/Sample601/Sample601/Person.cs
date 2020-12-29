using System;

namespace Sample601
{
    public class Person
    {
        //名前フィールド
        public string name = "";

        //年齢フィールド
        public int age = 0;

        public void ShowAgeAndName()
        {
            Console.WriteLine("名前:{0} 年齢:{1}", name, age);
        }

        public void SetAgeAndName(string name,int age)
        {
            //this = 自分自身のインスタンスのこと
            this.name = name;
            this.age = age;
        }

        public Person()
        {
        }
    }
}
