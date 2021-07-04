using System;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            
            int y = 0;

            Console.WriteLine("Please input number:");
            int inputNum = int.Parse(Console.ReadLine());
            y = inputNum;
            while (y != 0)
            {
                num = y % 10;
                y = y / 10;
                sum = sum + num * num * num;
            }
            if (sum == inputNum)
            {
                Console.WriteLine("{0}是水仙花数", inputNum);
            }
            else
            {
                Console.WriteLine("{0}不是水仙花数", inputNum);
            }
            
           
        }
    }
}
