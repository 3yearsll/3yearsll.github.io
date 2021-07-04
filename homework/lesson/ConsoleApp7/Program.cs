using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数");
            int inputNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数");
            int inputNum2 = int.Parse(Console.ReadLine());
            if (inputNum1 < inputNum2)
            {
                int temp = inputNum1;
                inputNum1 = inputNum2;
                inputNum2 = temp;
            }
            int i = 0;
            for( i = inputNum1; i <= inputNum1;i--)
            {
                if (inputNum1 % i == 0 && inputNum2 % i == 0)
                {
                    break;
                }
            }
            Console.WriteLine(i); 
        }
    }
}
