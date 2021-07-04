using System;

namespace ConsoleApp19
{
    class Program
    {
        static Boolean result;//是否为闰年结果
        
        static int[] monthArray = {0, 31, 0, 31, 30, 31, 30, 31, 31, 30, 30, 31, 30 };
        
        public static Boolean IsLoop(int year)
        {
            result = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) ? true : false;
            return result;
        } 
        public static int Days(Boolean result, int month,int date)
        {
            int days=0;
            monthArray[2] = result == true ? 29 : 28;
            for(int i = 0; i < month; i++)
            {
                days = monthArray[i] + days;
            }
            days = date + days;
            return days;
        }
        public static void Week(int year,int date)
        {
            int days = 0;//日期和
            int result1 = 0;
            for(int i = 1990; i < year; i++)
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
            days = days + date;
            result1 = days % 7;
            switch (result1)
            {
                case 0: Console.WriteLine("星期日");break;
                case 1: Console.WriteLine("星期一"); break;
                case 2: Console.WriteLine("星期二"); break;
                case 3: Console.WriteLine("星期三"); break;
                case 4: Console.WriteLine("星期四"); break;
                case 5: Console.WriteLine("星期五"); break;
                case 6: Console.WriteLine("星期六"); break;
            }
        }
        public static int WeekNum(int days)
        {
            int result1 = (days + 6) / 7;
            return result1;
        }
        public static void PrintCalendar(Boolean result, int year,int month)
        {
            int d = 1; 
            int j = 0;
            int k = 1;
            int days = 0;
            monthArray[2] = result == true ? 29 : 28;
            for (int i = 0; i < month; i++)
            {
                days = monthArray[i] + days;
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 11:j = 31;break;
                case 2:j = monthArray[2];break;
                case 4:
                case 6:
                case 9:
                case 10:
                case 12:j = 30;break;
            }
            int result1 = (days + 1) % 7;
            Console.WriteLine("日\t 一\t二\t三\t四\t五\t六");
            while(k<result1)
            {
                Console.Write("\t");
                k++;
            }    
            while(d<=j)
            {
                Console.Write("{0:00}",d+"\t");
                d++;
                if (d%7==0) { Console.WriteLine(); }
            }  

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("请输入年:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入月:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入日:");
            int date = int.Parse(Console.ReadLine());
            Boolean result = IsLoop(year);
            int days = Days(result,month,date);
            Week(year, days);
            Console.WriteLine(days);
            int weekNum = WeekNum(days);
            Console.WriteLine(weekNum);
            PrintCalendar(result, year, month);
        }
        
    }
    
}
