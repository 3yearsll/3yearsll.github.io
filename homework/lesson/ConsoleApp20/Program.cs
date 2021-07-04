using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if((input>='A' && input<='Z')||input>='a' && input <= 'z')
            {
                Console.WriteLine((int)input);
            }
            if(input>='0' && input <= '9')
            {
                Console.WriteLine(input-'0');
            }
        }
    }
}
