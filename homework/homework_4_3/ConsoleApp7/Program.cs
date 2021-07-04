using System;
using System.Text.RegularExpressions;

namespace ConsoleApp7
{
    class Program
    {   
        public  static string Del1(string input)
        {
            Regex r = new Regex(@"\p{P}");
            input = input.Replace(" ", "");
            string result=r.Replace(input,"");
            return result;
        }
        public static string Dele(string input)
        {
            
            for(int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]) && !char.IsLetter(input[i]))
                {
                    input=input.Remove(i, 1);
                }
            }
            input=input.Replace(" ", "");
            return input;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine(Del1( "Hello, World!"));
        }
    }
}
