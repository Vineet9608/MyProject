using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.stringdemo
{
    class Removecharacter2nd
    {


		static int NO_OF_CHARS = 256;
		static int[] getCharCountArray(String str)
		{
			int[] count = new int[NO_OF_CHARS];
			for (int i = 0; i < str.Length; i++)
				count[str[i]]++;

			return count;
		}

		
		static String removeDirtyChars(String str,
									String mask_str)
		{
			int[] count = getCharCountArray(mask_str);
			int ip_ind = 0, res_ind = 0;

			char[] arr = str.ToCharArray();

			while (ip_ind != arr.Length)
			{
				char temp = arr[ip_ind];
				if (count[temp] == 0)
				{
					arr[res_ind] = arr[ip_ind];
					res_ind++;
				}
				ip_ind++;
			}

			str = new String(arr);

			
			return str.Substring(0, res_ind);
		}

		
		public static void Main()
		{
			String str = "COUNTRY";
			String mask_str = "TRY";
			Console.WriteLine(removeDirtyChars(str, mask_str));
		}
	}

	

}
