using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.array
{
    class Togglecase
    {
        static void Main(string[] args)
        {
            string str1;
            char[] arr1;
            int l, i;
            l = 0;
            char ch;
            Console.WriteLine(" Input the string");
            str1 = Console.ReadLine();
            l = str1.Length;
            arr1 = str1.ToCharArray(0, l);
            Console.WriteLine("After conversion the string is:");
            for(i=0;i<l;i++)
            {
                ch = arr1[i];
                if (char.IsLower(ch))
                Console.WriteLine(char.ToUpper(ch));
                else
              Console.WriteLine(char.ToLower(ch));
            }
            Console.WriteLine("\n\n");
        }
    }
}
