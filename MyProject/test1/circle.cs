using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter radius");
            double Radius = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radius * Radius;
            Console.WriteLine("Area of circle :" + Area);
            Console.ReadKey();
                
        }
    }
}
