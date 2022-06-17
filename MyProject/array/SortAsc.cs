using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.array
{
    class SortAsc
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 65, 21, 61, 62, 70 };
            int temp = 0;
            Console.WriteLine("Element of original array:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Element of array sorted in ascending order");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
