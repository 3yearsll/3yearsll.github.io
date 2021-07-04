using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int b = 0;
            for (int i = 1; i < 10000; i++)
            {
                for (int a = 1; a < i;a++)
                {
                    if (i % a == 0)
                    {
                        
                        b = b + a;
                        c = b;
                        
                    }
                    
                }
                b = 0;
                if (i == c)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}