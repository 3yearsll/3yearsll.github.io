using System;
//冒泡排序
namespace ConsoleApp2
{
    class Program
    {
        public static void Paixu(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - 1-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("排序后的数组为:");
            foreach(int i in arr)
            {
                Console.Write(i + "\t");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 4, 7, 4, 8, 5, 89, 4, 4, 324, 8, 2 };
            Paixu(arr);
        }
    }
}
