using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.encapsulation
{
    class Engine1
    {
        private string typeofengine;

        public string Typeofengine
        {
            get;
            set;
        }
    }
    class Carproperty
    {
        private int price;
        private string color;
        private string name;
        private Engine1 eng;
        public int Price
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;

        }
        public Engine Eng
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Carproperty c = new Carproperty();
            c.price = 65000000;
            c.color = "red";
            c.name = "ferrari";
            Engine1 e = new Engine1();
            e.Typeofengine = "internal combustion engine";
            Console.WriteLine(c.price+" ,"+c.color+" ,"+c.name+" ,"+e.Typeofengine);

        }
    }
    
}
