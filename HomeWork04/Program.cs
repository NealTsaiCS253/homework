using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game();
        }

        public static int GetUserInput()
        {
            Console.Write("請輸入你要出的招：1.剪刀，2.石頭，3.布 : ");
            return int.Parse(Console.ReadLine());
        }

        public static int GetNpcInput()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        public static void GetResult(int GuestA, int GuestB)
        {
            string message = "GuestA {0}, GuestB {1}, Result [ {2} ]";
            string result;
            string guestAInput;
            string guestBInput;
            if (GuestA == GuestB)
            {
                result = "Draw";
            }
            else if ((GuestA == 1 && GuestB == 2) || (GuestA == 2 && GuestB == 3) || (GuestA == 3 && GuestB == 1))
            {
                result = "GuestB Victory";
            }
            else
            {
                result = "GuestA Victory";
            }

            if (GuestA == 1)
            {
                guestAInput = "剪刀";
            }
            else if (GuestA == 2)
            {
                guestAInput = "石頭";
            }
            else guestAInput = "布";

            if (GuestB == 1)
            {
                guestBInput = "剪刀";
            }
            else if (GuestB == 2)
            {
                guestBInput = "石頭";
            }
            else guestBInput = "布";

            //if (GuestA == GuestB)
            //{
            //    result = "Draw";
            //}
            //else if (GuestA == 1 && GuestB == 2)
            //{
            //    result = "GuestB Victory";
            //}
            //else if (GuestA == 1 && GuestB == 3)
            //{
            //    result = "GuestA Victory";
            //}
            //else if (GuestA == 2 && GuestB == 1)
            //{
            //    result = "GuestA Victory";
            //}
            //else if (GuestA == 2 && GuestB == 3)
            //{
            //    result = "GuestB Victory";
            //}
            //else if (GuestA == 3 && GuestB == 1)
            //{
            //    result = "GuestB Victory";
            //}
            //else
            //{
            //    result = "GuestA Victory";
            //}
            //if (GuestA == 1)
            //{
            //    guestAInput = "剪刀";
            //}
            //else if (GuestA == 2)
            //{
            //    guestAInput = "石頭";
            //}
            //else guestAInput = "布";

            //if (GuestB == 1)
            //{
            //    guestBInput = "剪刀";
            //}
            //else if (GuestB == 2)
            //{
            //    guestBInput = "石頭";
            //}
            //else guestBInput = "布";

            message = string.Format(message, guestAInput, guestBInput, result);
            Console.WriteLine(message);
        }

        public static void Game()
        {
            int person1 = GetUserInput();
            //int person2 = GetUserInput();
            int person2 = GetNpcInput();
            GetResult(person1, person2);
        }
    }
}