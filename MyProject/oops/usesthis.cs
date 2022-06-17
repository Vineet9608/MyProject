using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.oops
{
    class usesthis
    {
        int model_no;
        string c_name;
        string c_color;
        int price;

        void input(int model_no, string c_name, string c_color, int price)
        {
            this.model_no= model_no;
            this.c_name=c_name;
            this.c_color=c_color;
            this. price=price;
            this.display();
        }
        void display()
        {
            Console.WriteLine(model_no+" "+c_color+" "+c_name+" "+price);
        }
        static void Main(string[] args)
        {
            usesthis e = new usesthis();
            e.input(2034, "mg hector", "black", 78345669);
            e.display();
        }
    }
}
