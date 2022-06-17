using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.inheritance
{
    class Automobiles
    {
        protected string engine ="internal combustion engine";
        protected int seat = 4;
        
    }
    class car:Automobiles
    {
        string carname = "ferrari";
        int speed = 180;
        void show()
        {
            Console.WriteLine(" car name is" + carname);
            Console.WriteLine("engine is" + engine);
            Console.WriteLine(" car name is "+ carname);
            Console.WriteLine("speed is"+  speed);
        }
        static void Main(string[] args)
        {
            car c = new car();
            c.show();
        }
    }
}
