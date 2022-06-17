using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.inheritance
{
    class Employee
    {
        protected float salary = 50000;
    }
    class Programmer :Employee 
    {
        int bonus = 10000;
        void show()
        {
            Console.WriteLine("Programmer salary is:" + salary);
            Console.WriteLine("Bonus of Programmer is" + bonus);
        }
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            p.show();
        }
    }
}
