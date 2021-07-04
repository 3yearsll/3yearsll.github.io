using System;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
		{
			int sum = 0;
			for(int i = 3; i <= 100; i++)
            {
				if(i%3==0 && i % 5 != 0)
                {
					sum = sum + i;
                }
				Console.WriteLine(sum);
				Console.ReadLine();
            }
		}
	}
}
