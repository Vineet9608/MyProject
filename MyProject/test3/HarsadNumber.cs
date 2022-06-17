using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test3
{
    class HarsadNumber
    {
        static void Main(string[] args)
        {
            int num, rem =0,sum=0,n;
            Console.WriteLine("enter the number:");
            num = int.Parse(Console.ReadLine());
            n = num;
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            if (num % sum == 0)
            {
                Console.WriteLine(n + "is a Harshad Number");
            }
            else 
            { 
                Console.WriteLine(n + "is not a Harshad Number");
            }

        }

    }
}
