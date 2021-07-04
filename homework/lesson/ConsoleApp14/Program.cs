using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int result=0 ;
            int result1 = 0;
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 0; i <= 10000; i++)
            {
                for(int j = i / 2; j >= 1; j--)
                {
                    if (i % j == 0)
                    {
                        result = j;
                        result1 = j / result;
                        sum = sum + result + result1;
                        sum1 = sum - i;
                    }
                    if (sum1 == i)
                    {
                        sum2 = sum2 + sum1;
                    }
                    
                }
            }
            Console.WriteLine(sum2);

        }
    }
}
