using System;
using System.Text;

namespace Pracitse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder s1 = new StringBuilder();
            for(int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    Console.Write(char.ToLower(input[i]));
                }
            }
        }
    }
}
