using System;
/*编写程序，要求从键盘输入三个整数，并根据对三个数的比较显示如下信息：
①如果三个数都不相等则显示0；
②如果三个数中有二个数相等则显示1；
③如果三个数都相等，则显示2
*/
namespace Topic14
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            int result = 0;
            if(input1!=input2 && input1 != input3 && input2 != input3)
            {
                result = 0;
            }
            if (input1 == input2 || input1 == input3 || input2 == input3)
            {
                result = 1;
            }
            if (input1 == input2 && input1 == input3 && input2 == input3)
            {
                result = 2;
            }
            Console.WriteLine(result);
        }
    }
}
