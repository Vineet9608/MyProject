using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.encapsulation
{
    class Department 
    {
        public int did;
        public string dname;
        public Department(int did,string dname)
        {
            this.did = did;
            this.dname = dname;
        }
        public void show()
        {
            Console.WriteLine(did+" "+dname);
        }
    }
    class Empconstructor
    {
        int id;
        string name;
        Department dept;
        public Empconstructor(int id,string name,Department dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;

        }
        void display()
        {
            Console.WriteLine(id+" "+name+" "+dept.did+" "+dept.dname);
        }
        static void Main(string[] args)
        {
            Empconstructor e = new Empconstructor(901, "kalyani ambedkar", new Department(401, "trainer"));
            e.display();
        }
    }
}
