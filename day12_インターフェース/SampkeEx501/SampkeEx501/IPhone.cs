using System;
namespace SampkeEx501
{
    //  電話インターフェース
    interface IPhone
    {
        //  指定した番号に電話をかける
        void Call(string number);
    }
}
