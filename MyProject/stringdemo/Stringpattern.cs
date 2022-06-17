using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.stringdemo
{
    class Stringpattern
    {
        static void Main(string[] args)
        {
            string str = "I LIKE INDIA COUNTRY";
            string []str1 = str.Split(" ");
            for (int row=0;row<str1.Length;row++)
            {
                for (int col =0;col<=row;col++)
                {
                    Console.Write(str1[col]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
