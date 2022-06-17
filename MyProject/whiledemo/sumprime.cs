using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.whiledemo
{
    class sumprime
    {
        static void Main(string[] args)
        {
            int n, i, p, k, s = 0;
            Console.Write("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= n; i++)
            {
                k = 2;
                p = 1;
                while (k < i)
                {
                    if (i % k == 0)
                    {
                        p = 0;
                        break;

                    }
                    k++;
                }
                if(p==1)
                {
                    s = s + i;

                }
            }
            Console.WriteLine("sum of prime number:"+s);

            
            

            
        }
    }
}
