using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.methodoverloding
{
    class calculatearea
    {
        void area(int r)
        {
            Console.WriteLine("ara of circle"+(Math.PI*r*r));
        }
        void area(int l,int b)
        {
            Console.WriteLine("area of rectangle"+(l*b));
        }
        void area(int b,float h)
        {
            Console.WriteLine("area of traingle"+(0.5*b*h));
        }
        void area(float s)
        {
            Console.WriteLine("area of square"+(s*s));
        }
        static void Main(string[] args)
        {
            calculatearea a = new calculatearea();
            a.area(5);
            a.area(9, 7);
            a.area(5, 0.5f);
            a.area(5.5f);
        }
    }
}
