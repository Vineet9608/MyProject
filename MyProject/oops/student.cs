using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.oops
{
    class student
    {
        int id;
        string name;
        int m1;
        int m2;
        int m3;
        int p;

        public void input()
        {
            id = 101;
            name = "priyanka";
            m1 = 70;
            m2 = 60;
            m3 = 50;


        }
        public void calculate()
        {
            p= m1+ m2 + m3 / 3;


        }
        public void display()
        {
            Console.WriteLine(id+" "+name+" "+m1+" "+m2+" "+m3);
        }
        static void Main(string[] args)
        {
            student s = new student();
            s.input();
            s.calculate();
            s.display();


        }
    }
}
