using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test2
{
    class trimorphic
    {
        static void Main(string[] args)
        {
            int num, flag = 0, cube;
            Console.WriteLine("enter no");
            num = int.Parse(Console.ReadLine());
            cube = num * num * num;
            while(num!=0)
            {
                if(num%10!=cube%10)
                {
                    flag = 1;
                    break;
                }
                num /=10;
                cube /=10;
            }
            if(flag==0)
                Console.WriteLine("it is trimorphic");
            else
                Console.WriteLine("it is not  trimorphic");
            Console.ReadKey();
        }
    }
}
