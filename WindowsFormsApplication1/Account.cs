using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Account
    {
        public static string username;
        public static int balance;
        public Account(string name, int bal)
        {
            username = name;
            balance = bal;
           /* if (name == "Gbemisola")
            {
                balance = 5000;
            }
            else if (name == "Jacob")
            {
                balance = 10000;
            }
            else if (name == "Opeyemi")
            {
                balance = 1000;
            }*/
        }
        public int Deposit(int Amount){
            if (Amount < 0)
            {
                return 0;
            }
            else
            {
                balance += Amount;
                return balance;
            }
        }
        public int Withdraw(int Amount)
        {
            if (Amount <= balance)
            {
                 balance -= Amount;
                return balance;
            }
            else
            {
                return -1;
            }
        }
        public int  Balance()
        {
            return balance;
        }
        public void Transfer()
        {

        }

    }
}
