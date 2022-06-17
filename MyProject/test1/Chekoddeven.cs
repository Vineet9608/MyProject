using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class Chekoddeven
    {
        static void Main(string[]args)
        {
            int num;
            Console.WriteLine("enter a number");
            num = int.Parse(Console.ReadLine());
            if(num % 2==0)
            {
                Console.WriteLine("number is even");

            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }
    }
}
