using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int month = GetMonthInput();
            while (month > 12 || month < 1)
            {
                Console.WriteLine("Error Input, Please try again");
                month = GetMonthInput();
            }
            ConverSeason(month);
        }

        public static int GetMonthInput()
        {
            Console.Write("請輸入月份(1~12): ");
            return int.Parse(Console.ReadLine());
        }

        public static void ConverSeason(int month)
        {
            string strMonth = month.ToString();
            switch (strMonth)
            {
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("{0}月是春天", strMonth);
                    break;

                case "6":
                case "7":
                case "8":
                    Console.WriteLine("{0}月是夏天", strMonth);
                    break;

                case "9":
                case "10":
                case "11":
                    Console.WriteLine("{0}月是秋天", strMonth);
                    break;

                case "12":
                case "1":
                case "2":
                    Console.WriteLine("{0}月是冬天", strMonth);
                    break;
            }
        }
    }
}