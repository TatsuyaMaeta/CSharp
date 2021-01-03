using System;

namespace SampleEx301
{

    //Calculatorクラスを継承していて、そこのフィールド、メソッドの両方を使用できる
    class ExCalculator : Calculator　　//この書き方で継承できる
    {

        //  掛け算
        public void mul()
        {
            //今num1はprotectedになっているが、num2がprivateになっている為、エラーになっている
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }
        //  割り算
        public void div()
        {
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}
