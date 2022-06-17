using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.array

{
    class DARRAY
    {


        static void Main(string[] args)
        {
            DARRAY obj = new DARRAY();
            obj.AddTwoDArray();
            Console.ReadLine();
        }

        void AddTwoDArray()
        {
            Console.Write("Enter Number to Define Rows & Column:- ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[arrayLength, arrayLength];
            int[,] arraySecond = new int[arrayLength, arrayLength];
            int[,] arraySum = new int[arrayLength, arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("Array Index [{0}][{1}]:- ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("This is Your First Array:-");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(array[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + array[i, j]);
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Now Enter Your Second Array");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("Array Index [{0}][{1}]:- ", i, j);
                    arraySecond[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("This is Your Second Array:-");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(arraySecond[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + arraySecond[i, j]);
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Do you want to add this arrays:- (Y/N)");

            string userInput = Convert.ToString(Console.ReadLine());

            if (userInput.ToUpper() == "Y")
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    for (int j = 0; j < arrayLength; j++)
                    {
                        arraySum[i, j] = array[i, j] + arraySecond[i, j];
                    }
                }
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Array is Added Successfully Here is your Result");
                Console.WriteLine("---------------------------------------------------------------------");
                for (int i = 0; i < arrayLength; i++)
                {
                    for (int j = 0; j < arrayLength; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write(arraySum[i, j]);
                        }
                        else
                        {
                            Console.Write(" " + arraySum[i, j]);
                        }

                    }
                    Console.WriteLine();
                }
            }
           
        }
    }
}   
    