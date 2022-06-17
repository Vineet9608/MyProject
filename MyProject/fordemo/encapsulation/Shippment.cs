using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.encapsulation
{
    class Mydate
    {
        string date;
        public Mydate(string date)
        {
            this.date = date;
        }
        public void displaydate()
        {
            Console.WriteLine(date);
        }
    }

    class Order
    {
        int orderid;
        string customer_id;
        int price;
        string city;
        Mydate date;
        public Order(int orderid, string customer_id, int price, Mydate date)
        {
            this.orderid = orderid;
            this.customer_id = customer_id;
            this.price = price;
            this.date = date;
        }
        public void display()
        {
            Console.WriteLine(orderid + " " + customer_id + " " + price + " ");
            date.displaydate();
        }




    }

    class Shippment
    {
        int shippmentid;
        Order ord;
        Shippment(int shippmentid, Order ord)
        {
            this.shippmentid = shippmentid;
            this.ord= ord;
        }
        void show()
        {
            Console.WriteLine(shippmentid);
            ord.display();
        }
        static void Main(string[] args)
        {
            Mydate date = new Mydate("2-may-2021");
            Order ord = new Order(154785, "kalyani ambedkar", 7500,date);
            Shippment s = new Shippment(173565898, ord);
            s.show();
        }
    }
}
