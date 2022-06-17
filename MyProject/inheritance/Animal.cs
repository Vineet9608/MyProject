using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.inheritance
{
    class Animal
    {
        protected string eat = "herbivores";
        protected string barking = "woo woo";
    }
    class Dog : Animal
    {
        int legs = 4;
        static void Main(string[] args)
        {
            Dog D = new Dog();
            Console.WriteLine("Dog is a " +D.eat+ " animals");
            Console.WriteLine("dog barks "  +D.barking);
            Console.WriteLine("dog has " +D.legs+ " legs");
        }
    }
}
