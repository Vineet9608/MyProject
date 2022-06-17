using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayTest
{
    class Frequency
    {
      
                      


        public static void Main()
        {
            String str = "grass is greener on the other side";
            int[] freq = new int[str.Length];
            char minChar = str[0], maxChar = str[0];
            int i, j, min, max;

             
            char[] string1 = str.ToCharArray();

            
            for (i = 0; i < string1.Length; i++)
            {
                freq[i] = 1;
                for (j = i + 1; j < string1.Length; j++)
                {
                    if (string1[i] == string1[j] && string1[i] != ' ' && string1[i] != '0')
                    {
                        freq[i]++;

                        
                        string1[j] = '0';
                    }
                }
            }

             
            min = max = freq[0];
            for (i = 0; i < freq.Length; i++)
            {

                   
                 
                if (min > freq[i] && freq[i] != '0')
                {
                    min = freq[i];
                    minChar = string1[i];
                }
                 
                
                if (max < freq[i])
                {
                    max = freq[i];
                    maxChar = string1[i];
                }
            }

            Console.WriteLine("Minimum occurring character: " + minChar);
            Console.WriteLine("Maximum occurring character: " + maxChar);
        }
    }
  


}

