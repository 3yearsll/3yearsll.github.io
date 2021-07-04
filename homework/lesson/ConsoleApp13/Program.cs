using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个一位数:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                sum = sum * 10 + num;
                Console.Write("{0}+", sum);
            }
            
        }
    }
}
