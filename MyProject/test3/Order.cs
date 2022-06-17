using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.test3
{
    class Order
    {
        int order_id;
        string city;
        string cust_name;
        bool isdeliverd;
        static void Main(string[] args)
        {
            Order o = new Order();
            o.order_id = 153002;
            o.city = "pune";
            o.cust_name = "kalyani ambedkar";
            if (o.isdeliverd = true)
            {
                Console.WriteLine(o.order_id + " " + o.city + " " + o.cust_name);
                Console.WriteLine("order item is deliverd sorry for in convience");
            }
            
        }
    }
}
