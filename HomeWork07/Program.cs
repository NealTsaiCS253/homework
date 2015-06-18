using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string mode = SelectSumFunction();
            int number = GetNumberInput();
            SumNumber(number, mode);
        }

        public static string SelectSumFunction()
        {
            Console.WriteLine("Please select Sum Function(odd or normal)");
            return Console.ReadLine();
        }

        public static int GetNumberInput()
        {
            Console.WriteLine("Please enter Value(x)");
            return int.Parse(Console.ReadLine());
        }

        public static void SumNumber(int number, string mode)
        {
            int sumNumber = 0;

            switch (mode)
            {
                case "odd":
                    for (int i = 1; i <= number; i += 2)
                        sumNumber += i;
                    Console.WriteLine("{0}", sumNumber);
                    break;

                case "normal":
                    for (int i = 1; i <= number; i++)
                        sumNumber += i;
                    Console.WriteLine("{0}", sumNumber);
                    break;

                default:
                    Console.WriteLine("Select wrong mode!!! Please try again.");
                    break;
            }
        }
    }
}