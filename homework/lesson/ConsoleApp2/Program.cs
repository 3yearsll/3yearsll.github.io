using System;
//2.从键盘上输入数，求出该数的阶乘累加和。
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum1 = 1 ;
            Console.WriteLine("请输入一个数字:");
            int inputNum = int.Parse(Console.ReadLine());
            if (inputNum <= 0)
            {
                Console.WriteLine("请输入一个大于0的数");
            }
            else
            {
                for (int i = 1; i <= inputNum; i++)
                {
                    sum1 = i * sum1;
                    sum = sum + sum1;
                }
                Console.WriteLine("{0}的乘阶累加和是{1}", inputNum, sum);
            }
            
        }
    }
}
