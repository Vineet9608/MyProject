using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Nesteddemo
{
    class pattern4
    {
        static void Main(string[] args)
        {
            int i, j, rows, k = 1;
            Console.Write("enter numbr of rows:");
            rows = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=rows;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("{0}",k++);
                    Console.Write("\n");
                }
            }
        }
    }
}
