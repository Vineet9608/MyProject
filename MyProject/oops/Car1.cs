using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.oops
{
    class Car1
    {
        public string model;
        public string name;
        public string color;
        public int price;
        static void Main(string[] args)
        {
            
            Car1 D1 = new Car1();
            D1.model = "tata";
            D1.name = " nexon";
            D1.color = "blue";
            D1.price = 1300000;
            Car1 D2 = new Car1();
            D2.model = "tata";
            D2.name = " mg hector";
            D2.color = "white";
            D2.price = 1936000;
            Console.WriteLine(D1.model+" "+D1.name+" "+D1.color+" "+D1.price);
            Console.WriteLine(D2.model + " " +D2.name + " " +D2.color + " " +D2.price);




        }
    }
}
