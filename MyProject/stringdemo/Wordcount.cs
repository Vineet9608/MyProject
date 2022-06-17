using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.stringdemo
{
    class Wordcount
    {
        public static void Main()
        {
            String sentence = "Beauty lies in the eyes of beholder";
            int wordCount = 0;

            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if (sentence[i] == ' ' && Char.IsLetter(sentence[i + 1]) && (i > 0))
                {
                    wordCount++;
                }
            }
            wordCount++;
            Console.WriteLine("Total number of words in the given string: " + wordCount);
        }  
    }



}

