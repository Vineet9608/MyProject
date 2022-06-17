using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.switchDemo
{
    class odd
    {
        class oddeven
        {
            static void Main(string[] args)
            {
                int num;
                Console.WriteLine("enter any number to check even or odd");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num % 2)
                {
                    case 0:
                        Console.WriteLine(num + "is even no");
                        break;
                    case 1:
                        Console.WriteLine(num + "is odd number");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
