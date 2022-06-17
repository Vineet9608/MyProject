using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.switchDemo
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculator");
            Console.WriteLine("1.add");
            Console.WriteLine("2.substract");
            Console.WriteLine("3.multiply");
            Console.WriteLine("4.divide");
            Console.WriteLine("enter choice(1-4)");
            int ch = int.Parse(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.WriteLine("enter a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("sum = {0}", c);
                    break;
                case 2:
                    Console.WriteLine("enter a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("difference = {0}", c);
                    break;
                case 3:
                    Console.WriteLine("enter a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("multiplication = {0}", c);
                    break;
                case 4:
                    Console.WriteLine("enter a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("divison = {0}", c);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}

    

