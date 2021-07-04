using System;

namespace days
{
    class Program
    {
        static int NowYear = DateTime.Now.Year;
        static int NowMonth = DateTime.Now.Month;
        static int NowDay = DateTime.Now.Day;
        static int[] monthArr = { 0, 31, 0, 31, 30, 31, 30, 31, 31, 30, 30, 31, 30 };
        public static Boolean IsLoop (int year)//判断是否为闰年
        {
            Boolean isLoop = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) ? true : false;
            return isLoop;
        }
        public static int MonthCal(int year,int month,int date)//计算某月某日在今年是第几天
        {
            int result = 0;
            monthArr[2] = IsLoop(year) == true ? 29 : 28;
            for(int i = 0; i < month; i++)
            {
                result = result + monthArr[i];
            }
            result =result+date;
            return result;

        }
        public static int LifeCal(int year,int month,int date)//从出到现在活了多少天
        {
            int sum = IsLoop(year) == true ? 366 : 365;
            
            int days = 0;
            for(int i = year + 1; i < NowYear ; i++)
            {
                Boolean result = IsLoop(i);
                days = result == true ? days += 366 : days += 365;
            }
            days = days + sum-MonthCal(year, month, date);
            days = days + MonthCal(NowYear, NowMonth, NowDay);
            return days;
        }
        public static void DaysCal(int year)
        {
            int count1 = 0;
            int count2 = 0;
            int result1 = 0;
           
            for(int i = 1900; i <= year; i++)
            {
                if (IsLoop(i) == true)
                {
                    result1 += 366;
                    count1++;
                }
                else
                {
                    result1 += 365;
                    count2++;
                }
            }
            Console.WriteLine("从1900年到你出生年一共过了{0}天,闰年有{1}个,平年有{2}个", result1, count1, count2);
        }
        public static int ChildrenDayCal(int year,int month)
        {
            int sum = 0;
            if (month < 6 && NowMonth>=6 )
            {
                for(int i = year; i <= NowYear;i++)
                {
                    sum++;
                }
            }
            if (month < 6 && NowMonth < 6) 
            {
                for (int i = year; i < NowYear;i++)
                {
                    sum++;
                }
            }
            if(month > 6 && NowMonth > 6)
            {
                for (int i = year+1; i < NowYear; i++)
                {
                    sum++;
                }
            }
            if (month > 6 && NowMonth < 6)
            {
                for (int i = year + 1; i < NowYear-1; i++)
                {
                    sum++;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("请输入出生年：");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入出生月：");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入出生日：");
            int date = int.Parse(Console.ReadLine());
            Console.WriteLine("你从出生到现在一共活了{0}天",LifeCal(year,month,date));
            DaysCal(year);
            Console.WriteLine(ChildrenDayCal(year, month));
        }
    }
}
