using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要判断的数:");
            int num = int.Parse(Console.ReadLine());
           
            int sum = 0;
            int result = 0;
            int a = num;
            while (a > 0)
            {
                result = a % 10;
                sum = sum*10 + result;
                a= a / 10;
            }
            if (sum == num)
            {
                Console.WriteLine("是");

            }
            else 
            {
                Console.WriteLine("不是");
            }
            
        }
    }
}
