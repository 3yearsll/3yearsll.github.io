using System;
/*10. 编写程序，从键盘上输入一个字符：
若该字符是数字字符，则把它转换为对应的整数并输出；
若该字符是大写字母，则转换成小写并输出；
若该字符是小写字母，则转换为大写并输出；
若该字符是其他字符，则不进行任何操作。
*/
namespace Topic10
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if(input>='0' && input <= '9')
            {
                Console.WriteLine(input-'0');
            }
            else if(input>='A' && input <= 'Z')
            {
                Console.WriteLine((char)(input + 32));
            }
            else if (input >= 'a' && input <= 'z')
            {
                Console.WriteLine((char)(input - 32));
            }
        }
    }
}
