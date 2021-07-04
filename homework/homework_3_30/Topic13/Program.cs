using System;
//分段函数
namespace Topic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result=0;
            if (input < -1)
            {
                result = 1;
            }
            else if (input <= 1)
            {
                result = input * 2 + 9;
            }
            else if ( input <= 10)
            {
                result = 5 * input - 3;
            }
            else if (input <= 20)
            {
                result = input * input - 3 * input + 2;
            }
            Console.WriteLine(result);
        }
    }
}
