using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test3
{

    class Factorstatic
    {
        static void factor(int num)
        {
            int i=0;
            Console.WriteLine("The all factor of "+ num +" are :");
            for (i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i+" ");
                }
                
            }
        }
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("enter an integer:");
            num = int.Parse(Console.ReadLine());
            factor(num);
            Console.WriteLine();
        }
    }
}
