using System;

namespace narcissistic_Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int units = 0;
            int tens = 0;
            int hundreds = 0;
            int count = 0;
            int sum = 0;
            for(int i = 100; i <= 999; i++)
            {
                units = i % 10;
                tens = i/10 % 10; 
                hundreds = i / 100;
                sum = units * units * units + tens * tens * tens + hundreds * hundreds * hundreds;
                if (sum == i)
                {
                    count++;
                }
            }
            
            Console.WriteLine("100~999内共有{0}个水仙花数",count);
        }
    }
}
