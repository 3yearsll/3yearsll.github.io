using System;

namespace ConsoleApp1
{
    
    class Test
    {
        public static void Yuesefu(int amount,int kill,int start)
        {
            Random ra = new Random();
          
            int[] arr = new int[amount];

            int i = start;
            int alive = amount;
            int count = 0;
            Console.WriteLine(amount+" " + kill+" "+ start);
            while (alive > 1)
            {


               
                if (arr[i] == 0)
                {
                        count++;
                    
                        
                        if (count == kill)
                        {
                            count = 0;
                            alive--;
                            arr[i] = 1;
                        }
                }
                i++;
                if (i == amount)
                {
                    i = 0;
                }

            }
            
            foreach(int j in arr)
            {
                Console.Write(j + "\t");
            }
            
        }

        public static void Gys(int input1,int input2)
        {
            int max = input1 > input2 ? input1 : input2;
        }
       public static void Main(string[] args)
        {
            Yuesefu(13, 3, 0);
        }
    }
}