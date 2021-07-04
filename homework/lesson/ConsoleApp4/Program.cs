using System;
//4.从键盘上输入两个数，求出最大公约数和最小公倍数
namespace ConsoleApp4
{
    class Program
    {   
        public static void gbs(int inputNum1,int inputNum2)
        {
            int[] result = new int[2];
            int max = inputNum1 > inputNum2 ? inputNum1 : inputNum2;
            int min = inputNum1 < inputNum2 ? inputNum1 : inputNum2;
            int a = 0;
            int leastCommonMultiple = 0;


            while (min != 0)
            {
                a = max % min;
                max = min;
                min = a;

            }
           
            leastCommonMultiple = (inputNum1 * inputNum2) / max;
            Console.WriteLine("{0}和{1}的最大公约数是{2}", inputNum1, inputNum2, max);
            Console.WriteLine("{0}和{1}的最小公倍数是{2}", inputNum1, inputNum2, leastCommonMultiple);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数");
            int inputNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数");
            int inputNum2 = int.Parse(Console.ReadLine());
             
            
          
        }
    }
}
