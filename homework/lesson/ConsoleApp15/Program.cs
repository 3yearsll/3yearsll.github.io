using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个一位数:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum * 10 + num;
                sum1 = sum1 + sum;
                if (i < 4)
                {
                    Console.Write("{0}+", sum);
                }
                else
                {
                    Console.Write("{0}={1}", sum,sum1);
                }
                
            }

        }
        
    }
}
