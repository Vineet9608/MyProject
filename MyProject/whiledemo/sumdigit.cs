using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.whiledemo
{
    class sumdigit
    { 
        static void Main(string[] args)
        {
            int n, sum = 0, m;
            Console.WriteLine("enter a no");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine("sum is" + sum);
        }
    }
    }



