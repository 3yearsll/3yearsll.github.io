using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入要判断的ip:");
            string input = Console.ReadLine();
            string[] arr = input.Split(".");
            int count = 0;
            if (arr.Length < 4)
            {
                Console.WriteLine("error");
            }
            else 
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Convert.ToInt32(arr[i]) >0&& Convert.ToInt32(arr[i]) <= 255)
                    {
                        count++;
                    }
                }
            }
            if (count == 4 && count == 6)
            {
                Console.WriteLine("合法");
            }
            else
            {
                Console.WriteLine("不合法");
            }
        }
    }
}
