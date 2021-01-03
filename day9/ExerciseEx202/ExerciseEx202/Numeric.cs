using System;

namespace ExerciseEx202
{
    public class Numeric
    {
        // public static MaxCalc(int a, int b) で戻り値がある場合のそれの型がなかったのでエラー表示だった
        public static　int Max(int a, int b) {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
