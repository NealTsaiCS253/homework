﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int grade = int.Parse(GetGrade());
            int grade = GetGrade();
            PrintGrade(grade);
        }

        //public static string GetGrade()
        //{
        //    Console.Write("Please Enter your Score: ");
        //    return Console.ReadLine();
        //}

        public static int GetGrade()
        {
            Console.Write("Please Enter your Score: ");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintGrade(int grade)
        {
            if (grade > 100)
                Console.WriteLine("\nYour Score is out of Range");
            else
            {
                Console.Write("\nYour Score is ");
                //if (grade <= 100 && grade >= 90)
                //    Console.WriteLine("Grade-A");
                //else if (grade < 90 && grade >= 80)
                //    Console.WriteLine("Grade-B");
                //else if (grade < 80 && grade >= 70)
                //    Console.WriteLine("Grade-C");
                //else if (grade < 70 && grade >= 60)
                //    Console.WriteLine("Grade-D");
                //else Console.WriteLine("Grade-E");
                switch (grade / 10)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("Grade-A");
                        break;

                    case 8:
                        Console.WriteLine("Grade-B");
                        break;

                    case 7:
                        Console.WriteLine("Grade-C");
                        break;

                    case 6:
                        Console.WriteLine("Grade-D");
                        break;

                    default:
                        Console.WriteLine("Grade-E");
                        break;
                }
            }
        }
    }
}