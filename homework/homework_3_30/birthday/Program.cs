using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static Boolean isLoop;
        static int[] monthArr = { 0, 31, 0, 31, 30, 31, 30, 31, 31, 30, 30, 31, 30 };

        public static Boolean IsLoopYear(int year)
        {
            isLoop = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) ? true : false;
            return isLoop;
        }
        public static void DaysAdd(int year)
        {
            int count = 0;
            int count1 = 0;
            int result = 0;
            int result1 = 0;

            for (int i = 1900; i <= year; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    result = result + 366;
                    count++;
                }
                else
                {

                    result1 = result1 + 365;
                    count1++;
                }

            }
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(count);
            Console.WriteLine(count1);


        }
        public static int AgeCal(int year, int month, int day)
        {
            int days = 0;
            int days1 = 0;
            int days2 = 0;
            int result = 0;
            monthArr[2] = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) ? 29 : 28;
            int NowYear = DateTime.Now.Year;
            int NowMonth = DateTime.Now.Month;
            int NowDay = DateTime.Now.Day;
            for (int i = year; i < NowYear - 1; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    days = days + 366;

                }
                else
                {

                    days = days + 365;

                }
            }
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {


            }
            else
            {

                days = days + 365;

            }
            for (int i = 0; i < NowMonth; i++)
            {
                days1 = days1 + monthArr[i];
            }
            result = days + days1 + NowDay;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入出生年：");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入出生月：");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入出生日：");
            int date = int.Parse(Console.ReadLine());
            DaysAdd(month);
            int ageCal = AgeCal(year, month, date);
            Console.WriteLine(ageCal);


        }
    }
}
