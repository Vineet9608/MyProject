using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.oops
{
    class bank
    {
        int account_no;
        string account_type;
        string customer_name;
        int balance;
        public void details()
        {
            account_no = 3429471;
            account_type = "saving";
            customer_name = "kalyani ambedkar";
            balance = 500000;
        }
        public void display()
        {
            Console.WriteLine(account_no+" "+account_type+" "+customer_name+" "+balance);
        }
        public void withdraw()
        {
            balance = balance - 10000;
            Console.WriteLine(balance);
        }
        public void deposit()
        {
            balance = balance + 50000;
            Console.WriteLine(balance);
            
        }
        static void Main(string[] args)
        {
            bank b = new bank();
            b.details();
            b.display();
            b.withdraw();
            b.deposit();

        }
    }
}
