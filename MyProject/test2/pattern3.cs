using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test2
{
    class pattern3
    {
        static void Main(string[] args)
        {
            int x, y;
            for(x=5;x>=1;x--)
            {
                for(y=1;y<=x;y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
