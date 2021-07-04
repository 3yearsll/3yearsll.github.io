using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int feb = 0;
            int i = 0;
            if((year%4==0 && year % 100 != 0) || year % 400 == 0)
            {
                feb = 29;
            }
            else
            {
                feb = 28;
            }
            switch (month)
            {
                case 1: break;
                case 2:i = 31 + day;break;
                case 3: i = 31 + feb + day; break;
                case 4: i = 62 + feb + day; break;
                case 5: i = 92 + feb + day; break;
                case 6: i = 123 + feb + day; break;
                case 7: i = 153 + feb + day; break;
                case 8: i = 184 + feb + day; break;
                case 9: i = 215 + feb + day; break;
                case 10: i = 245 + feb + day; break;
                case 11: i = 276 + feb + day; break;
                case 12: i = 306 + feb + day; break;


            }
            Console.WriteLine("{0}年{1}月{2}日是{0}年的第{3}天",year,month,day,i);
        }
    }
}
