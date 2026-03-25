using System;

namespace BankingSystem
{
    internal class Account
    {
        private decimal _balance;
        private string _name;

        public string Name
        {
            get { return _name; }
        }

        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

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

        public void Print()
        {
            Console.WriteLine($"Account Holder: {Name}");
            Console.WriteLine($"Balance: {_balance:C}");
        }
    }
}