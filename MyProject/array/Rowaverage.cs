using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.array
{
    class Rowaverage
    {
        static void Main()
        {
            double sum = 0, avg = 0;
            Console.Write("How many numbers you want to enter?");
            int n = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("The Average is : " + avg);
            Console.ReadKey();
        }
    }
}
