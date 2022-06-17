using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class percentage
    {
        static void Main(string[] args)
        {
            int marks1, marks2, marks3, marks4, marks5, total;
            float average, percentage;
            Console.WriteLine("enter marks1 :");
            marks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks 2:");
            marks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks 3 :");
            marks3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks  4:");
            marks4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks 5:");
            marks5 = Convert.ToInt32(Console.ReadLine());
            total = marks1 + marks2 + marks3 + marks4 + marks5;
            average = total / 5.0f;
            percentage = total / 5.0f;
            Console.WriteLine("total marks:" + total);
            Console.WriteLine("average:" + average);
            Console.WriteLine("percentage" + percentage);

        
    }
    }
}
