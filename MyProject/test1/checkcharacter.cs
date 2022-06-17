using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class checkcharacter
    {
        static void Main(string[]args)
        {
            char ch;
            Console.WriteLine("enter any character:");
            ch = Convert.ToChar(Console.ReadLine());
            if((ch >='a'&& ch<='z')||(ch>='A'&& ch<='Z'))
            {
                Console.WriteLine(ch + " is an alphbet");
            }
            else if(ch>='0'&& ch<='9')
            {
                Console.WriteLine(ch + "is a digit");

            }
            else
            {
                Console.WriteLine(ch + "is a special symbol");
                Console.ReadLine();
            }
        }
    }
}
