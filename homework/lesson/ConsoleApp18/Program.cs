using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double result = 0;
            int ret = 0;
            while (true)
            {
                if (input <= 0)
                {
                    Console.WriteLine("请输入一个正数");
                    break;
                }
                else
                {   ret = (int) input;
                    double num = Math.Floor(input);
                    result = input - num;
                    ret = (result >= 0.5) ? ret + 1:ret;
                    break;
                }
                
            }
            Console.WriteLine("{0}四舍五入后为{1}",input,ret);
        }
    }
}
