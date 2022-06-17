using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.array
{
    class Methodarraysum
    {
        int add;
        int []sum(int[]a)
        {
            for (int i = 0; i < a.Length; i++)
            {

                add = add + a[i];
            }
            Console.WriteLine("Sum of Element " + add);
            return a;
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 6, 8, 9 };
            Methodarraysum s = new Methodarraysum();
            int[] b = s.sum(arr);
        }
    }
}
