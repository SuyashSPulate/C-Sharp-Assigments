using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7._2_StreamWriter_StreamReader
{
    internal class Account
    {
        public int account_number;
        public string customer_name;
        public double balance;


        public Account(int accno, string name, double bal)
        {
            account_number = accno;
            customer_name = name;
            balance = bal;
        }
    }
}
