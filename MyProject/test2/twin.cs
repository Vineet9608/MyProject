using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test2
{
    class twin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = int.Parse(Console.ReadLine());
            Boolean prime = true;
            for(int i=2;i<=a/2;i++)
            {
                if (a % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if(prime && Math.Abs(a -b) ==2)
            {
              prime = true;
                for (int i = 2; i <= b / 2; i++)
                {
                   if(b%i==0)
                    {
                       prime = false;
                        break;
                    }
                }
                    
            }
            if (prime)
                Console.WriteLine(a + " and " + b + "are twin prime");
            else
                Console.WriteLine(a + " and " + b + "are not twin prime");


        }
    }
}
