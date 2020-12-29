using System;

namespace Sample501
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c;
            Double sum, ave;

            a = 1.2;
            b = 3.7;
            c = 4.1;

            double[] d = new double[3];

            d[0] = a;
            d[1] = b;
            d[2] = c;

            Console.WriteLine(a + " " + b + " " + c);

            sum = a + b + c;
            ave = sum / 3.0;

            for (int i = 0; i < d.Length; i++)
            {
                sum += d[i];
            }
        



            Console.WriteLine("sum: " + sum);
            Console.WriteLine("ave: " + ave);

            Console.WriteLine("※※※※※※※※※※※※※※※※※※");
            Console.WriteLine(d[1]);
        }
    }
}
