using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.inheritance
{
    public class Father
    {
        public string Fathername()
        {
            return "Ravi";
        }
    }
    public class Childfirst : Father
    {
        public string Childname()
        {
            return "rohan";
        }
    }
    public class Childsecond : Father
    {
        public string childname()
        {
            return "nikhil";
        }
    }   
    class Hierarchial
    {
        static void Main(string[] args)
        {
        Childfirst fir = new Childfirst();
        Console.WriteLine("my name is " + fir.Childname() + " my father name is " + fir.Fathername());
        Childsecond sec = new Childsecond();
        Console.WriteLine("my name is "+sec.childname()+" my father name is " +sec.Fathername());
        }
    }
}
