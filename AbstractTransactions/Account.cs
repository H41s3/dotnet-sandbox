using System;

namespace BankingSystem
{
    class Account
    {
        private string _name;
        private decimal _balance;

        public string Name { get { return _name; } }
        public decimal Balance { get { return _balance; } }

        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        // Adds the given amount to the balance — returns false if the amount is zero or negative
        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
                return false;
            _balance += amount;
            return true;
        }

        // Deducts the given amount — returns false if there are not enough funds
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > _balance)
                return false;
            _balance -= amount;
            return true;
        }

        public void Print()
        {
            Console.WriteLine("Account: " + _name);
            Console.WriteLine("Balance: $" + _balance.ToString("F2"));
        }
    }
}