using System;
using System.Text;

namespace ConsoleApp8
{   
    
    class Program
    {
        public static void Resrve(string input)
        {
            StringBuilder sb = new StringBuilder();
            string[] s = input.Split(' ');
            
            for(int i = 0; i < s.Length / 2; i++)
            {
                string temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
            foreach(string i in s)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            for(int i = 0; i < s.Length; i++)
            {
                string temp = s[i];
                for(int j = temp.Length - 1; j >= 0; j--)
                {
                    sb.Append(temp[j]);
                }
            }
            Console.WriteLine(sb);
        }
        static void Main(string[] args)
        {
            Resrve("Hello World");
        }
    }
}
