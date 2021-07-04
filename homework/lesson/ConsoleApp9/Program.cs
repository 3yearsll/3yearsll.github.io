using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int sum = 0;
            int result = 0;
            string inputNum = " ";
            List<int> intList = new List<int>();
            int temp = 0;
            int count = 1;
            Console.WriteLine("判断回文数,输入a停止");

            while (true)
            {
                
                Console.WriteLine("第{0}个:",count);
                inputNum = Console.ReadLine();
                count++;
                if (inputNum == "a")
                {
                    break;
                }
                intList.Add(int.Parse(inputNum));
               
            }
            
            
             for (int i = 0; i < intList.Count ; i++)
             {
                temp = intList[i];//备份
                 
                 
              
            
            
                while (temp > 0)
                {
                    result = temp % 10;
                    sum = sum * 10 + result;
                    temp  = temp / 10;
                }
                if (sum == intList[i])
                {
                    Console.WriteLine("{0}是回文数", intList[i]);
                }
                else
                {
                    Console.WriteLine("{0}不是回文数", intList[i]);
                }
                
                sum = 0;//重置sum
            }
        }
    }
}
