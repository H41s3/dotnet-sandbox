using System;

namespace BankingSystem
{
    class Account
    {
        private string _name;
        private decimal _balance;

        public string Name => _name;
        public decimal Balance => _balance;

        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        // Returns true only if the amount is positive
        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
                return false;

            _balance += amount;
            return true;
        }

        // Returns true only if the amount is positive and funds are sufficient
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > _balance)
                return false;

            _balance -= amount;
            return true;
        }

        public void Print()
        {
            Console.WriteLine($"Account:  {_name}");
            Console.WriteLine($"Balance:  ${_balance:F2}");
        }
    }
}