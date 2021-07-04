using System;

namespace Topic16
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            int min = 0;
            min = input1 < input2 ? input1 : input2;
            min = min < input3 ? min : input3;
            Console.WriteLine(min);
        }
    }
}
