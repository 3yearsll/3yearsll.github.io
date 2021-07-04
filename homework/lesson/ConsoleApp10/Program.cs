using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int excellent = 0;//优秀人数
            int good = 0;//良好人数
            int mid = 0;//中等人数
            int pass = 0;//及格人数
            int failed = 0;//不及格人数
            double stu = 10;
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("请输入第{0}个学生的成绩", i+1);
                int score = int.Parse(Console.ReadLine());
                if(score>100 || score < 0)
                {
                    Console.WriteLine("请输入一个大于零小于等于一百的数");
                    stu--;
                }

                else 
                {
                    if (score < 60)
                    {
                        failed++;
                    }
                    else if (score < 70)
                    {
                        pass++;
                    }
                    else if (score < 80)
                    {
                        mid++;
                    }
                    else if (score < 90)
                    {
                        good++;
                    }
                    else
                    {
                        excellent++;
                    }
                }
                
            }
            Console.WriteLine("优秀比率为{0:F2}",excellent /stu  );
            Console.WriteLine("良好比率为{0:F2}", good / stu);
            Console.WriteLine("中等比率为{0:F2}", mid / stu);
            Console.WriteLine("及格比率为{0:F2}", pass / stu);
            Console.WriteLine("不及格比率为{0:F2}", failed / stu);
            
        }
    }
}
