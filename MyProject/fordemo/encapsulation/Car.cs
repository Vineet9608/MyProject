using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.encapsulation
{
    class Car
    {
        private int model;
        private string name;
        private string color;
        private int price;
        public int Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
    class carinfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Model = 05236;
            c.Name = "royll royce";
            c.Color = "white";
            c.Price = 2345600;
            Console.WriteLine(c.Model+" "+c.Name+" "+c.Color+" "+c.Price);
        }
    }
}
