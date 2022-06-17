using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.encapsulation
{
    class Engine
    {
        
        public string typeofengine;
        public Engine(string typeofengine)
        {
            this.typeofengine = typeofengine;
        }
        public void show()
        {
            Console.WriteLine(typeofengine);
        }
    }
    class Carconstructor
    {
        int price;
        string color;
        string name;
        Engine eng;
        public Carconstructor(int price,string color,string name, Engine eng)
        {
            this.price = price;
            this.color = color;
            this.name = name;
            this.eng = eng;
        }
        void display()
        {
            Console.WriteLine(price+", "+color+" ,"+name+", "+eng.typeofengine);

        }
        static void Main(string[] args)
        {
            Engine e = new Engine("external combustion engine");
            Carconstructor c = new Carconstructor(32000000, "black", "mustang",e);
            c.display();
        }
    }
}
