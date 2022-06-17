using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test2
{
    class Averageeven
    {
        static void Main(string[] args)
        {
            int num, sum = 0, rem, count = 0;
            Console.WriteLine("enter the digit");
            num = int.Parse(Console.ReadLine());
            while(num>0)
            {
                rem = num % 10;
                num = num / 10;
                if(rem%2==0)
                {
                    count++;
                    sum = sum + rem;
                }
            }
            Console.WriteLine(sum/count);
        }
    }
}
