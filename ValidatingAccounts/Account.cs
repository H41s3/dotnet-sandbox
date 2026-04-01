// Account.cs - Represents a single bank account

using System;

namespace BankingSystem
{
    class Account
    {
        // Private fields - hidden from outside code
        private decimal _balance;
        private string _name;

        // Read-only property: outside code can read the name but not change it
        public string Name
        {
            get { return _name; }
        }

        // Constructor: sets up the account with a name and starting balance
        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        // Deposits money into the account.
        // Returns true if successful, false if the amount is invalid (zero or negative).
        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
                return false; // reject invalid deposit

            _balance += amount;
            return true;
        }

        // Withdraws money from the account.
        // Returns false if amount is invalid or exceeds current balance.
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                return false; // reject invalid withdrawal

            if (amount > _balance)
                return false; // not enough funds

            _balance -= amount;
            return true;
        }

        // Prints account details to the console
        public void Print()
        {
            Console.WriteLine("Account Name: " + _name);
            Console.WriteLine("Balance:      $" + _balance.ToString("F2"));
        }
    }
}