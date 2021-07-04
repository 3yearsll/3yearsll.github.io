using System;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {   
        public static void find(string input,string target)
        {
            StringBuilder sb = new StringBuilder();
            int index = input.IndexOf(target, StringComparison.OrdinalIgnoreCase);
            int count = 0;
            int[] result = new int[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);
            }
            Console.WriteLine(sb);
            int temp = 0;
            while (index != -1)
            {
                for (int i = 0; i <=target.Length; i++)
                {
                    temp = index;
                    if (char.IsUpper(input[temp]))
                    {
                        sb.Replace(input[temp], char.ToLower(input[temp]), temp, 1);
                    }
                    else
                    {
                        sb.Replace(input[temp], char.ToUpper(input[temp]), temp, 1);
                    }
                    temp++;
                }
                result[count] = index;
                count++;
                index += target.Length;
               
                index = input.IndexOf(target,index ,StringComparison.OrdinalIgnoreCase);
            }
            Console.WriteLine(sb);
            for(int i = 0; i < count; i++)
            {
                Console.Write(result[i]);
            }

        }
        static void Main(string[] args)
        {
            find("abcA", "a");          
        }
    }
}
