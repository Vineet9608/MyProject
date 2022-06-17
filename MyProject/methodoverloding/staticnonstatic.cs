using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.methodoverloding
{
    class staticnonstatic
    {
        static int x;
        int y;
        public void addition(int x,int y)
        {
        Console.WriteLine("addition"+(x+y));
        }
        public static void divison(int x,int y)
        {
            staticnonstatic c = new staticnonstatic();
            //Console.WriteLine("divison"+(x/c.y));
        }

    }
    class main
    {
        static void Main(string[] args)
        {
            staticnonstatic d = new staticnonstatic();
            d.addition(100,200);
            staticnonstatic.divison(625, 25);

        }
    }
}
