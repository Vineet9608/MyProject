using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test1
{
    class simpleintrest
    {
        static void Main(string[] args)
        {
            double p,r,t,si;
            Console.Write("Enter principal amount=");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter interest rate=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time=");
            t = Convert.ToDouble(Console.ReadLine());
            si= p* r * t / 100;
            Console.Write("simple intrest="+si);
            Console.ReadKey();

        }
    }
}
