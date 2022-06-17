using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.stringdemo
{
	class Averagedigitstring
	{

		public static void Main()
		{
			string str;
			Console.WriteLine("Enter a string ");
			str = Console.ReadLine();
			int count, sum = 0,average=0;
			int n = str.Length;

			for (count = 0; count < n; count++)
			{ 
				if ((str[count] >= '0') && (str[count] <= '9'))
				{
					sum += (str[count]-'0' );
					
				}
			}
	
				// average= sum / count;
			      Console.WriteLine("sum = " +sum+" "+count);
               // Console.WriteLine("average= "+average);
		}
}	}



