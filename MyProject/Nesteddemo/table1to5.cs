using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Nesteddemo
{
    class table1to5
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=5; i++)
            {
                for(int j=1;j<=10;j++)
                {
                    Console.WriteLine("{0}*{1} ={2}",i,j,i*j);
                    
                }
                Console.WriteLine("----------------------");

            }
            Console.ReadKey();
        }
    }
}
