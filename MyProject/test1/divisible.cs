using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class divisible
    {
        static void Main()
        {
            int num;
            Console.WriteLine("enter number :");
            num = Convert.ToInt32(Console.ReadLine());
            if((num % 5==0)&&(num % 11==0))
            {
                Console.WriteLine("number is divisble by 5 and 11" + num);

            }
            else
            {
                Console.WriteLine("number is not divisible by 5 and 11" + num);
            }
        }
    }
}
