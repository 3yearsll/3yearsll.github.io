using System;
using System.Text;

//在一个字符串中找到第一个只出现一次的字符。如输入abaccdeff，则输出b。
namespace ConsoleApp2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("请输入:");
            string input = Console.ReadLine();
            char s1 =' ';
            for (int i=0; i < input.Length; i++)
            {

             
                    if (input.IndexOf(input[i])==input.LastIndexOf(input[i]))
                    {
                        s1=input[i];
                    break;
                        
                    }
                 
                    

                

              


            }
            Console.WriteLine(s1);
        }
    }
}
