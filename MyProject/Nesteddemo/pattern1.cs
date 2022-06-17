using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Nesteddemo
{
    class pattern1
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=5;i>=1;i--)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
