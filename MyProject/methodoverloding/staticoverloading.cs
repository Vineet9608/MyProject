using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.methodoverloding
{
    class staticoverloading
    {
        static void calculate(int a, int b)
        {
            Console.WriteLine("adddition of integer"+(a+b));
        }
        static void calculate(double c, double d)
        {
            Console.WriteLine("addition of double"+(c+d));



        }
        static void Main(string[] args)
        {
            staticoverloading.calculate(2, 3);
            staticoverloading.calculate(4.0, 5.0);
        }
    }
}
