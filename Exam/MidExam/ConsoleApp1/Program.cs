using System;
//最大公约数与最小公倍数
namespace ConsoleApp1
{
    //辗转相除法
    
    class Program
    {
        public static void Gbs(int num1, int num2)
        {
            int max = num1 > num2 ? num1 : num2;
            int min = num1 < num2 ? num1 : num2;
            while (min!=0)
            {
                int temp = max % min;
                max = min;
                min = temp;
            }
            int le = num1 * num2 / max;//最小公倍数
            Console.WriteLine("辗转相除法:");
            Console.WriteLine("最大公约数为{0}", max);
            Console.WriteLine("最大公约数为{0}", le);
        }
        //穷举法
        public static void  Gbs2(int num1,int num2)
        {
            int min = num1 < num2 ? num1 : num2;
            int result = 0;
            for(int i = min; i > 0; i--)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    result = i;
                    break;
                }
            }
            int le = num1 * num2 / result;//最小公倍数
            Console.WriteLine("穷举法:");
            Console.WriteLine("最大公约数为{0}", result);
            Console.WriteLine("最大公约数为{0}", le);
        }
        static void Main(string[] args)
        {
            
            Gbs(16, 36);
            Gbs2(16, 36);
        }
    }
}
