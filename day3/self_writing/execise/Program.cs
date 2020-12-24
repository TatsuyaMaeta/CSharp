using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _27_case {
    class Program {
        static void Main (string[] args) {;
            int n = int.Parse (Console.ReadLine ());

            switch (n)
            {
                case 1:
                    Console.WriteLine("one");
                    break;

                default:
                    Console.WriteLine("other");
                    break;
            }



            Console.WriteLine ("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

            string s1 = Console.ReadLine ();
            string s2 = Console.ReadLine ();

            if (s1 == "hello" && s2 == "world") {
                Console.WriteLine ("Good!");
            } else {
                Console.WriteLine ("Please enter 'Hello world'");
            }

            Console.WriteLine ("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

            double temp = double.Parse (Console.ReadLine ());

            if (temp == 0.0) {
                Console.WriteLine ("zero");
            } else if (temp > 0) {
                Console.WriteLine ("plus number");
            } else {
                Console.WriteLine ("minus number");
            }

        }
    }
}