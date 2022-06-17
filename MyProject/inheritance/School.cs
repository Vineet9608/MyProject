using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.inheritance
{
    class Principal
    {
        public void monitor()
        {
            Console.WriteLine("monitor a school");
        }
    }
    class Teacher : Principal
    {
        public void teach()
        {
            Console.WriteLine("teaches a student");
        }
    }
    class Student : Principal
    {
        public void learn()
        {
            Console.WriteLine("student learn from teacher and principal");
        }
    }

    class School
    {
        static void Main(string[] args)
        {
            Principal g = new Principal();
            g.monitor();
            Teacher d = new Teacher();
            d.monitor();
            d.teach();
            Student s = new Student();
            s.monitor();
            s.learn();
            Console.ReadKey();
        }
    }
}
