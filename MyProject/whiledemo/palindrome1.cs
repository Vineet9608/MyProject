using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.whiledemo
{
    class palindrome1
    {
            static void Main(string[] args)
            {
                int n, r, sum = 0, temp;
                Console.WriteLine("enter the number");
                n = int.Parse(Console.ReadLine());
                temp = n;
                while (n > 0)
                {
                    r = n % 10;
                    sum = sum * 10 + r;
                    n = n / 10;
                }
            if (temp == sum)
            {
                Console.WriteLine("no is palindrome");
            }
            else
            {
                Console.WriteLine("no is not palindrome");
            }
            }
        }
    }



