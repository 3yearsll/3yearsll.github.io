using System;

namespace Topic18
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            long money = int.Parse(Console.ReadLine());
            if (money <= 100000)
            {
                result = money * 0.1;
            }
            else if (money < 200000)
            {
                result = 100000 * 0.1 + (money - 100000) * 0.075;
            }
            else if (money < 400000)
            {
                result = 100000 * 0.1 + 100000 * 0.075 + (money - 200000) * 0.075;
            }
            else if (money < 600000)
            {
                result = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.075+(money-400000)*0.03;
            }
            else if (money < 1000000)
            {
                result = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.075 +200000 * 0.03+(money-600000)*0.015;
            }
            else
            {
                result=  100000 * 0.1 + 100000 * 0.075 + 200000 * 0.075 + 200000 * 0.03 + 600000 * 0.015+(money-1000000)*0.01;
            }
        }
    }
}
