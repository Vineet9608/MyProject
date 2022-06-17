using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.encapsulation
{
    class Student
    {
        private int id;
        private string name;
        private double per;
        public int Id
        {
            get;
            set;
        }
        public string Name 
        {
            get;
            set;
        }
        public double Per
        {
            get;
            set;
        }
       
    }
    class Studentinfo
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 6;
            s.Name = "Kalyani";
            s.Per = 45.06;
            Console.WriteLine(s.Id+" "+s.Name+" "+s.Per);
            bool isplaced = true;
            if(isplaced)
            {
                Console.WriteLine("set the true");
                
            }
            else
            {
                Console.WriteLine("set the false ");
            }
        }
    }
}
