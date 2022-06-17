using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class leapyear
    {
        static void Main(string[] args)
        {
            int chk_year;
            Console.WriteLine("check whether a given no is leap year or not :/n");
            Console.WriteLine("input  a year :");
            chk_year = Convert.ToInt32(Console.ReadLine());
            if ((chk_year % 4)== 0)
                {
                Console.WriteLine("given year is leap year", chk_year);
            }
        else
            {
                Console.WriteLine("given year is not leap year", chk_year);
            }
        }


    }
}
