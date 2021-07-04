using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {


            int sum = 0;
            int result = 0;
            string inputNum = "";
            
            int temp = 0;
            int count = 0;
            Console.WriteLine("判断回文数,输入a停止");

            while (true)
            {

                Console.WriteLine("请输入要判断的数字:");
                inputNum = Console.ReadLine();
                if(inputNum=="a" || inputNum=="A")
                {
                    break;
                }

                int input = int.Parse(inputNum);
                temp = input;
                
                while (temp > 0)
                {
                    result = temp % 10;
                    sum = sum * 10 + result;
                    temp = temp / 10;
                }
                if (sum == input)
                {
                    Console.WriteLine("{0}是回文数", input);
                    count++;
                }
                else
                {
                    Console.WriteLine("{0}不是回文数", input);
                }

                sum = 0;//重置sum


            }
            Console.WriteLine("一共有{0}个回文数", count);

            





               
            }
        }
    }

