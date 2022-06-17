using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayTest
{
    class Zerolast
    {
     
        
            static void Main(string[] args)
            {
                int[] array = new int[] {12,0,7,0,8,0,3};
                int[] result = Approach2(array);
                   
            }
            static int[] Approach2(int[] array)
            {
                int newArrayIndex = 0;
                int[] newArray = new int[array.Length];
                foreach (var element in array)
                {
                      
                    if (element == 0)
                        continue;
                      
                    newArray[newArrayIndex] = element;
                    newArrayIndex++;
                }
               
                for (int i = newArrayIndex; i < array.Length; i++)
                    newArray[i] = 0;
                return newArray;
            }
        

    }
}
