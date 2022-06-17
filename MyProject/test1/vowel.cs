using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test1
{
    class vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter char");
            char ch = Console.ReadLine()[0];
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("vowel");

            }
            else
            {
                Console.WriteLine("consonant");
            }
        }
    }
}
