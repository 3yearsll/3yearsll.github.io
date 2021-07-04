using System;
//翻转单词顺序
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入:");
            string input = Console.ReadLine();
            string[] s1 = input.Split(" ");
            for (int i = 0; i < s1.Length/2; i++) 
            {
               
                    string temp = s1[i];
                    s1[i] = s1[s1.Length-i-1];
                    s1[s1.Length-i-1] = temp;
                    
               

            }
            for (int i=0;i<s1.Length;i++) 
            {
                Console.Write(s1[i]+" ");
            }
        }
    }
}
