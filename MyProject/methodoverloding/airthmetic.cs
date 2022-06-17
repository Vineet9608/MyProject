using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.methodoverloding
{
    class airthmetic
    {
        void perform(int x, int y, int z)
        {
            Console.WriteLine("addition" + (x + y + z));
        }
        void perform(int a, int b)
        {
            Console.WriteLine("subtract" + (a - b));
        }
        void perform(float x, float y)
        {
            Console.WriteLine("multiplication" + (x * y));

        }
        void perform(double x, double y)
        {
            Console.WriteLine("divison" + (x / y));
        }
        static void Main(string[] args)
        {
            airthmetic a = new airthmetic();
            a.perform(10, 20, 30);
            a.perform(20, 30);
            a.perform(4.5f, 5.5f);
            a.perform(4.26, 2.2);

        }
    }
            

    
}
