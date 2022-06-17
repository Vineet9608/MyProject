using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test2
{
    class factorialsum
    {
        static void Main(string[] args)
        {
            int i, f=1, num,sum=0;
            Console.Write("input no");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                f = f * i;
                sum = sum + f;
            }
            Console.Write("factorial of"+sum);
        }
    }
}
