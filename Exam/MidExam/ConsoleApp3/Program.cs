using System;
//二分查找
namespace ConsoleApp3
{
    class Program
    {
        public static int Find(int[] arr,int target)
        {
            int result = -1;
            Array.Sort(arr);
            int low = 0;
            int high = arr.Length-1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == target)
                {
                    result = mid;
                    break;
                }else if (arr[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 34, 5, 34, 6, 43, 6, 3, 6, 87, 5, 6, 87, 54, 4 };
            int result = Find(arr, 5);
            Console.WriteLine(result);
        }
    }
}
