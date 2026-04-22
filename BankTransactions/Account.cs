using System;

namespace BankingSystem
{
    class Account
    {
        private decimal _balance;
        private string _name;

        // Expose name read-only — callers need it for display but shouldn't mutate it
        public string Name
        {
            get { return _name; }
        }

        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        // Returns false rather than throwing — lets callers decide how to handle failure
        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
                return false;

            _balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                return false;

            // Reject before mutating — never put the account in a partial state
            if (amount > _balance)
                return false;

            _balance -= amount;
            return true;
        }

        public void Print()
        {
            Console.WriteLine("Account Name: " + _name);
            Console.WriteLine("Balance:      $" + _balance.ToString("F2"));
        }
    }
}