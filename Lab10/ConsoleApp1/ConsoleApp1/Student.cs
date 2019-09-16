using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string name;

        public Student(string name)
        {
            this.name = name;

        }
        public void info()
        {
            Console.WriteLine("Имя студента: " + name);
        }
    }
}
