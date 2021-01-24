using System;
namespace SampkeEx501
{
    //  電子メール
    interface IEmail
    {
        //  メールを送る
        void SendMail(string address);
    }
}
