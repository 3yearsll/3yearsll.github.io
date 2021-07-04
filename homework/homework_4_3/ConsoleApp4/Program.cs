using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            char input2 = char.Parse(Console.ReadLine());
            char[] array1 = input1.ToCharArray();
            
            int count = 0;
            



                for (int i=0;i<array1.Length;i++)
                {
                    if(input2==array1[i])
                        count++;

                   
                }
                
            
            Console.WriteLine(count);
        }
    }
}
