using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            for(int i = 1; i <= 10000; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                    
                }
                if (sum == i)
                {
                    count++;
                }
                sum = 0;
            }
            Console.WriteLine("10000以内的完数和为{0}",count);
        }
    }
}
