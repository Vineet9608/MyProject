using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayTest
{
    class Square
    {
 
        static void countSquares(int[] arr, int N)
        {
          int count = 0;
            for (int i = 0; i < N; i++)
            {
                int square = arr[i] * arr[i];
                for (int j = 0; j < N; j++)
                {
                    if (arr[j] == square)
                    {
                        count = count + 1;
                    }
                }
            }
                   Console.WriteLine(count);
                  // Console.WriteLine(square);
        }

       
        static void Main()
        {
          int[] arr = { 23, 43, 25,49, 20,9, 16};
            int N = arr.Length;
            countSquares(arr, N);
        }
    }
}
