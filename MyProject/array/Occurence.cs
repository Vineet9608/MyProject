using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.array
{
    class Occurence
    {
        static void Main(string[] args)
        {
            int size;
            int[] a = { };
            Console.WriteLine("enter the array list");
            size= int.Parse(Console.ReadLine());
            int[] arr = new int[size];
           Console.WriteLine("Enter array values:");
            for (int i = 0; i < size; i++)
            {
             arr[i] = Convert.ToInt32(Console.ReadLine());
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[k]==a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j = i + 1; j < size; j++) 
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i]+" +count");
                }
            }
        }
    }
}
