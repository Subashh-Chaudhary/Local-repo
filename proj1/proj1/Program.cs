using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th
{
    internal class Account
    {
        private String name;
        private String acc_no;
        private String acc_type;
        private Double balance;
        private int pin;

        public Account(string name, string acc_no, string acc_type, double balance, int pin)
        {
            this.name = name;
            this.acc_no = acc_no;
            this.acc_type = acc_type;
            this.balance = balance;
            this.pin = pin;
        }
        public void withdraw(double amount)
        {
            if (balance > amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }
        public void deposite(double amount)
        {
            balance += amount;
        }
        public void viewBalance()
        {
            Console.WriteLine("The balance is:" + balance);
        }
        public Boolean Login(String acc_no, int pin)
        {
            if (this.acc_no == acc_no && this.pin == pin)
            {
                return true;
            }
            return false;
        }
    }
}