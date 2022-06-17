using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayTest
{
    class Refil
    {
        private string inkcolor;
        private int length;
        private string nib;
        public string Inkcolor
        {
            get { return inkcolor; }
            set { inkcolor = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Nib
        {
            get { return nib; }
            set { nib = value; }
        }
    }
    class Nib
    {
        private string materialtype;
        private int width;
        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

    }
    class Pengetset
    {
        private string refil;
        private int length;
        private string brand;
        Refil rf;
        Nib nb;
        public string Refil
        {
            get { return refil; }
            set { refil = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Refil Rf
        {
            get { return rf; }
            set { rf= value; }
        }
        public Nib Nb
        {
            get { return nb; }
            set { nb = value; }
        }
        static void Main(string[] args)
        {
            Pengetset p = new Pengetset();
            p.refil = "ball pen";
            p.length = 3;
            p.brand = "reynolds";
            p.rf.Inkcolor = "blue";
            p.rf.Length = 2;
            p.rf.Nib = "boll pen";
            p.nb.Materialtype = "alloy";
            p.nb.Width = 1;
            Console.WriteLine(p.refil+" "+p.length+" "+ p.brand+" "+ p.rf.Inkcolor+" "+ p.rf.Length+" "+ p.rf.Nib+" "+ p.nb.Materialtype+" " + p.nb.Width);
        }
    }
}
