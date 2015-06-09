using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = GetUserName();
            GuestUserGender(name);
            GetUserAnswer();
        }

        public static string GetUserName()
        {
            Console.Write("請輸入你的大名:");
            return Console.ReadLine();
        }

        public static void GuestUserGender(string name)
        {
            Random random = new Random();
            int intRandom = random.Next(0, 2);
            if (intRandom == 0)
            {
                Console.WriteLine("{0},妳是女生嗎?", name);
                //Console.WriteLine("妳是女生嗎?" + string.Format("{0}", intRandom));
            }
            else if (intRandom == 1)
            {
                Console.WriteLine("{0},你是男生嗎?", name);
                //Console.WriteLine("你是男生嗎?" + string.Format("{0}", intRandom));
            }
            else
            {
                Console.WriteLine("{0},可以跟我說你是男生還是女生嗎?", name);
                //Console.WriteLine(string.Format("{0}", intRandom));
            }
        }

        public static void GetUserAnswer()
        {
            Console.Write("請問我猜對了嗎?(請輸入yes/no)");
            string ans = Console.ReadLine();
            Console.WriteLine(IsYes(ans) ? "我猜對了，太準了吧!" : "其實我故意猜錯的");
        }

        public static bool IsYes(string ans)
        {
            return ans == "yes" || ans == "Yes" || ans == "y" || ans == "Y";
        }
    }
}