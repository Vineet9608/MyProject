using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class evenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("1.odd\n 2.even");
            Console.WriteLine("enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("even = " + (num % 2 == 0));
                    break;
                case 2: Console.WriteLine("odd = " + (num % 2 != 0));
                    break;
            }
        }
            
    }
}
