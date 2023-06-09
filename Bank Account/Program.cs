﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAcc account1 = new BankAcc("AB123", 100.0);
            BankAcc account2 = new BankAcc("CD456");
            account1.Deposit(200);
            account2.Deposit(130.5);
            Console.WriteLine($"Balance on {account1.GetNumber()}: {account1.GetBalance()}");
            Console.WriteLine($"Balance on {account2.GetNumber()}: {account2.GetBalance()}");
            double withdrawAmount = 200.35;
            bool isSuccessful = account1.Withdraw(withdrawAmount);

            if (isSuccessful)
            {
                Console.WriteLine($"Success! Balance on {account1.GetNumber()}:{ account1.GetBalance()}");
            }
            else
            {
                Console.WriteLine($"Failed! Not enough money on {account1.GetNumber()}");
            }
            if (account2.Withdraw(withdrawAmount))
            {
                Console.WriteLine($"Success! Balance on account {account2.GetNumber()}: " +
               account2.GetBalance());
            }
            else
            {
                Console.WriteLine($"Failed! Not enough money on account {account2.GetNumber()}");
            }
            BankAcc highest;
            if (account1.GetBalance() > account2.GetBalance())
            {
                highest = account1;
            }
            else
            {
                highest = account2;
            }
            Console.WriteLine($"Account {highest.GetNumber()} has the highest balance:{ highest.GetBalance()}");
 // account1.balance = 400;
 // CS0122: 'BankAccount.balance' is inaccessible due to its protection level
 }
    }

}
    

