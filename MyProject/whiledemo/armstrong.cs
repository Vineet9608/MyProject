using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.whiledemo
{
   
        class armstrong
        {
            static void Main(string[] args)
            {
                int n, r, sum = 0, temp;
                Console.WriteLine("Enter the no");
                n = int.Parse(Console.ReadLine());
                temp = n;
                while (n > 0)
                {
                    r = n % 10;
                    sum = sum + (r * r * r);
                    n = n / 10;
                }
            if (temp == sum)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("not armstrong");
            }
            }
        }
    }





