using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要判断的年份:");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year%400==0)
            {
                Console.WriteLine("{0}年是闰年", year);
            }
            else
            {
                Console.WriteLine("{0}年不是闰年", year);
            }
        }
    }
}
