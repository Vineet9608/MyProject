using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.encapsulation
{
    class Nib
    {
        private string materialtype;
        
        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }
        }
    }
    class Pen
    {
       private int length;
        private string color;
        private int price;
        
        public int Length
        {
            get;
            set;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Price
        {
            get;
            set;

        }
    }
    class Bag
    {
        private string brand;
        private string color;
        Nib nb;
        Pen pn;
        public string Brand 
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Color
        {
            get;
            set;
        }
        public Nib Nb
        {
            get;
            set;
        }
        public Pen Pn
        {
            get{ return pn; }
            set { pn= value; }
        }
        static void Main(string[] args)
        {
            Bag b = new Bag();
            b.brand = "puma";
            b.color = "black";
            b.pn = new Pen();
            b.pn.Length = 4;
            b.pn.Color = "blue";
            b.pn.Price = 50;
            b.nb = new Nib();
            b.nb.Materialtype = "barrel";

            Console.WriteLine(b.brand+", "+b.color+", "+b.pn.Length+" ,"+b.pn.Color+", "+b.pn.Price+" "+b.nb.Materialtype);
















        }
    }
    
}
