using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class maximum
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = 10;
            num2 = 20;
            num3 = 30;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("number one is largest ! /n");
                }
                else
                {
                    Console.WriteLine("number three is largest! /n");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("number two is the largest");
            }
            else
                Console.WriteLine("number three is largest");
        }        
    }
}
