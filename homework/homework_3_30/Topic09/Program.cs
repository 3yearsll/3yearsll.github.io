using System;
//09. 从键盘输入一个任意整数，判断它是不是对称数，并输出判断结果。如输入43234就是对称数。
namespace Topic09
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input = int.Parse(Console.ReadLine());
            int temp = input;
            while (temp > 0) 
            {
                sum = sum * 10 + (temp % 10);
                temp /= 10;
            }
            if (input == sum)
            {
                Console.WriteLine("{0}是对称数", input);
            }
            else
            {
                Console.WriteLine("{0}不是对称数", input);
            }
        }
    }
}
