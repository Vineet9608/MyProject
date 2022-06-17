using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.array
{
    class Oddposition
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Element of given array present on odd position");
            for(int i=0;i<arr.Length;i=i+2)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
