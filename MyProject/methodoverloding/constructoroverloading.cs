using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.methodoverloding
{
    class constructoroverloading
    {
         int roll;
         double height;
        string name;
        public constructoroverloading(double a,int x,string s)
        {
            roll = x;
            name = s;
            height = a;

        }
        public constructoroverloading(string s, int x, double a)
        {
            height = a;
            roll = x;
            name = s;
        }
            public void show()
            {
                Console.WriteLine("roll  no:" +roll);
                Console.WriteLine("height:"+ height+"feet");
                Console.WriteLine("name:"+name);
            }
        static void Main(string[] args)
        {
            constructoroverloading c1 = new constructoroverloading(5.8, 10, "kalyani");
            constructoroverloading c2 = new constructoroverloading(5.9, 11, "vineet");
            Console.WriteLine("first constructor:");
            c1.show();
            Console.WriteLine("second constructor:");
            c2.show();

        }

    }
}
