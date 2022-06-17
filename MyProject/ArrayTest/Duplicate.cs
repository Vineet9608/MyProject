using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayTest
{
    class Duplicate
    {
       
        public static T[] removeDuplicates<T>(T[] array)
        {
            HashSet<T> set = new HashSet<T>(array);
            T[] result = new T[set.Count];
            set.CopyTo(result);
            return result;
        }

        public static void Main()
        {
            int[] array = { 2, 3, 3, 4, 1, 2, 5 };
            int[] distinct = removeDuplicates(array);

            Console.WriteLine(String.Join(",", distinct));
        }
    }

}

