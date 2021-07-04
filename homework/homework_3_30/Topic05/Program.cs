using System;
//06. 从键盘输入一个4位正整数，求其各位数字之积，并输出。例如：若输入2523，则输出应该是60。
namespace Topic05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int input = int.Parse(Console.ReadLine());
            while (input > 0)
            {
                sum = sum * (input % 10);
                input /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
