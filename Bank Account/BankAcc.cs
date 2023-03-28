using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public class BankAcc
    {
        private string number;
        private double balance;
        // constructor that accepts two parameters
        public BankAcc(string num, double bal)
        {
            number = num;
            balance = bal;
        }
        // overloaded constructor that accepts only the number
        // the balance is set to 0
        public BankAcc(string num)
        {
            number = num;
            balance = 0;
        }
        // just add the specified amount to the balance
        public void Deposit(double amount)
        {
            balance += amount;
        }
        // check if there is enough money before withdrawing
        public bool Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
                return true;
            }
            return false;

        }
        public double GetBalance()
        {
            return balance;
        }
        public string GetNumber()
        {
            return number;
        }
        public void Close()
        {
            balance = 0;
        }
    }
}
