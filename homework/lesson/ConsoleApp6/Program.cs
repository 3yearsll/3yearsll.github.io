using System;
//6.实用循环完成输出斐波那契数列（前十个数），并计算数列之和。1,1,2,3,5,8,13,21,34,55
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 1;
            int secondNum = 1;
            int result = 0;
            int sum = 0;
            for(int i = 0; i <8; i++)
            {
                result = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = result;
                sum = result + sum;
                Console.WriteLine(result);
            }
            Console.WriteLine("前十项的和为{0}", sum);
        }
    }
}
