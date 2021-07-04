using System;
//05. 从键盘输入一个4位数，判断其是否能同时被3和5整除，且该数为奇数。如果是，输出Yes，否则输出No。
namespace homework_3_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if((input%3==0 && input%5==0) && input % 2 != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
