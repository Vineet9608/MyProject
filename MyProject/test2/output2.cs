using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test2
{
    class output2
    {
        static void Main(string[] args)
        {
            int i = 1, K = 1;
            while (i++ <= 5)
            {
                K *= i;
            }
            Console.WriteLine("k="+K+"i="+i);
        }
    }
}
