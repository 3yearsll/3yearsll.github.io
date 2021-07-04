using System;
//3.求出所有三位数中的水仙花数，如153=1*1*1+5*5*5+3*3*3。
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
            for (int i = 100; i <= 999; i++)
            {
                units = i % 10;
                tens = i / 10 % 10;
                hundreds = i / 100;
                sum = units * units * units + tens * tens * tens + hundreds * hundreds * hundreds;
                if (sum == i)
                {
                    count++;
                    Console.WriteLine("{0}={1}*{1}*{1}+{2}*{2}*{2}+{3}*{3}*{3}", sum,hundreds,tens,units);
                }
            }

            
        }
    }
}
