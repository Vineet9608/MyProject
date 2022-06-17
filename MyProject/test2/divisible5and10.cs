using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test2
{
    class divisible5and10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("divided by 3 & 5");
            for(int i=1;i<=100;i++)
            {
                if(i%5==0 && i%10==0)
                {
                    Console.WriteLine(i);

                }
            }
            Console.ReadKey();
        }
    }
}
