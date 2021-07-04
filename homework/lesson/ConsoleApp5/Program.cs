using System;
//5.从键盘上输入三角形三边边的长度，判定能否组成直角三角形。
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一条边");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二条边");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第三条边");

            int c = int.Parse(Console.ReadLine());
            
            if(a*a+b*b==c*c ||a*a+c*c==b*b || b*b+c*c==a*a) 
            {
                Console.WriteLine("以上三条边可以构成直角三角形");
            }
            else
            {
                Console.WriteLine("以上三条边不可以构成直角三角形");
            }
        }
    }
}
