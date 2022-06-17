using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Nesteddemo
{
    class menudriven
    {
        static void Main(string[] args)
        {
            int choice, r, l, w, b, h,s;
            double area = 0;
            Console.Write("a menu driven proogram");
            Console.Write("\n\n");
            Console.Write("area  of circle\n");
            Console.Write("area  of rectangle\n");
            Console.Write("area  of triangle\n");
            Console.Write("area  of square\n");
            Console.Write("input yr choice\n");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Input radius");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * r * r;
                    Console.Write(area);
                    break;
                case 2:
                    Console.Write("Input length");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input width");
                    w = Convert.ToInt32(Console.ReadLine());
                    area = l*w;
                    Console.Write(area);
                    break;
                case 3:
                    Console.Write("Input base");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input height");
                    h = Convert.ToInt32(Console.ReadLine());
                    area =0.5 * b * h;
                    Console.Write(area);
                    break;
                case 4:
                    Console.Write("Input side");
                    s = Convert.ToInt32(Console.ReadLine());
                    area= s*s;
                    Console.Write(area);
                    break;
                    
            }

        }
    }
}
