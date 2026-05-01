using System;

namespace BankingSystem
{
    class Account
    {
        // Private fields — only this class can read or change these directly
        private string _name;
        private decimal _balance;

        // Public read-only properties — other classes can read but not set these
        public string Name => _name;
        public decimal Balance => _balance;

        // Constructor — sets up a new account with a name and a starting balance
        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        // Adds money to the account — only works if the amount is positive
        // Returns true if the deposit was successful, false otherwise
        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
                return false;

            _balance += amount;
            return true;
        }

        // Removes money from the account — only works if funds are sufficient
        // and the amount is positive
        // Returns true if the withdrawal was successful, false otherwise
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > _balance)
                return false;

            _balance -= amount;
            return true;
        }

        // Prints the account name and current balance to the console
        public void Print()
        {
            Console.WriteLine($"Account:  {_name}");
            Console.WriteLine($"Balance:  ${_balance:F2}");
        }
    }
}