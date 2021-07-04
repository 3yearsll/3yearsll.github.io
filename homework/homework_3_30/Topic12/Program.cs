using System;
//成绩评级
namespace Topic12
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            char result;
            char result1;
            switch (score / 10)
            {
                case 6:result='D';break;
                case 7: result = 'C'; break;
                case 8: result = 'B'; break;
                case 9: 
                case 10: result = 'A'; break;
                default:result = 'E';break;
            }
            if (score < 60)
            {
                result1 = 'E';
            }
            else if (score < 70)
            {
                result1 = 'D';
            }
            else if (score < 80)
            {
                result1 = 'C';
            }
            else if (score < 90)
            {
                result1 = 'B';
            }
            else
            {
                result1 = 'A';
            }
            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
    }
}
