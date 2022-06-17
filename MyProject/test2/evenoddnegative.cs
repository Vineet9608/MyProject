using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test2
{
    class evenoddnegative
    {
        static void Main(string[] args)
        {
            int i;
           
            for(i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                        Console.WriteLine(-i * -i);

                }
            }
            
        }
    }
}
