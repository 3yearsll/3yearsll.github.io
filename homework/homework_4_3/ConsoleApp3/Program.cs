using System;
using System.Text;
//3.删除字符串中重复元素。
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入:");
            string input = Console.ReadLine();
            StringBuilder s1 = new StringBuilder();
            for (int i = 0; i < input.Length-1; i++)
            {             

                for (int j = i+1; j < input.Length-1;)
                {
                    if (input[i]==input[j])
                    {
                        s1.Append(input[j]);
                        

                    }
                    



                }

                

            }
            for(int i = 0; i < s1.Length; i++)
            {
                Console.Write(s1[i]);
            }
        }
    }
}
