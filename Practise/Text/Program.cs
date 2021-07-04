using System;


namespace ConsoleApplication1
{
    interface ICirle
    {
        double Area();
    }
    interface ISquare
    {
        double Area();
    }
    class FisArea : ISquare
    {
        public float len;

     
        
          public  double Area()
            {
                return len * len;

            }
        
    }
    class Program
    {
       
       static void Main(string[] args)
        {
            FisArea ss = new FisArea();
            ss.len = 2;
            Console.WriteLine(ss.Area());
             
           
        }
    }
}
