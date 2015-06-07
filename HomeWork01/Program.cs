using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string number1 = GetNumber();
            string number2 = GetNumber();
            string number3 = GetNumber();
            string number4 = GetNumber();

            int a = int.Parse(number1);
            int b = int.Parse(number2);
            int c = int.Parse(number3);
            int d = int.Parse(number4);

            int aa = Add(a, b);
            int bb = Add(c, d);

            Ans1st(string.Format("{0}", aa));
            Ans2nd(string.Format("{0}", bb));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static string GetNumber()
        {
            Console.Write("Please enter number:");
            return Console.ReadLine();
        }

        public static void Ans1st(string number)
        {
            Console.WriteLine("First Answer is {0}", number);
        }

        public static void Ans2nd(string number)
        {
            Console.WriteLine("Second Answer is {0}", number);
        }
    }
}