using System;

// BankingSystem namespace groups all related classes together
namespace BankingSystem
{
    // Account class represents a bank account with a name and balance
    internal class Account
    {
        // Stores the current balance of the account
        private decimal _balance;

        // Stores the name of the account holder
        private string _name;

        // Read-only property to access the account holder's name from outside the class
        public string Name
        {
            get { return _name; }
        }

        // Constructor — runs when a new Account object is created
        // Sets the initial name and balance
        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        // Deposit — adds money to the account
        // Validates that the amount is positive before updating balance
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New balance: {_balance:C}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Withdraw — removes money from the account
        // Validates that amount is positive AND does not exceed current balance
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New balance: {_balance:C}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        // Print — displays the account holder's name and current balance
        public void Print()
        {
            Console.WriteLine($"Account Holder: {Name}");
            Console.WriteLine($"Balance: {_balance:C}");
        }
    }
}