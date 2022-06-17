using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.whiledemo
{
    class spy1
    {
 
        static void Main(string[] args)
        {
            int num, product = 1, sum = 0, lastdigit;
            Console.WriteLine(" enter no");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                lastdigit = num % 10;
                sum = sum + lastdigit;
                product = product * lastdigit;
                num = num / 10;
            }
            if (sum == product)
            {
                Console.WriteLine("no is spy");

            }
            else
            {
                Console.WriteLine("no is not spy");

            }

        }
    }
    }



