using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.encapsulation
{
    class Address
    {
        private int pincode;
        private string city;
        public int Pincode
        {
            get;
            set;
        }
        public string City
        {
            get; 
            set;
        }

    }
    class Studentget
    {
        private int rollno;
        private string name;
        private Address adr;
        public int Rollno
        {
            get;
            set;
         }
        public string Name
        {
            get { return name;}
            set { name = value;}
         }
        public Address Adr
        {
            get { return adr; }
            set { adr = value; }
        }
        static void Main(string[] args)
        {
            Studentget s = new Studentget();
            s.Rollno = 102;
            s.Name = "Vineet";
            Address a = new Address();
            a.Pincode = 834002;
            a.City = "ranchi";
            Console.WriteLine(s.Rollno+" "+s.Name+" "+a.Pincode+" "+a.City);


        }
    }
}
