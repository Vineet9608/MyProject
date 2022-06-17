using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.switchDemo
{
    class nameday1
    {
        static void Main(string[] args)
        {
            int ch;
            Console.WriteLine("enter week no");
             ch = int.Parse(Console.ReadLine());
            switch (ch)
        {
            case 0:
                Console.WriteLine("sunday");
                break;
            case 1:
                Console.WriteLine("monday");
                break;
            case 2:
                Console.WriteLine("tuesday");
                break;
            case 3:
                Console.WriteLine("wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("friday");
                break;
            case 6:
                Console.WriteLine("saturday");
                break;
            }
        }
        }
}
