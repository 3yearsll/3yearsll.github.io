using System;
using System.Collections.Generic;
using System.Text;

namespace Test02
{
    class Student
    {
        string name;
        int age;
        public virtual void speak()
        {
            Console.WriteLine("你好");
        }
    }
}
