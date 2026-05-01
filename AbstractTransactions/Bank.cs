using System;
using System.Collections.Generic;

namespace BankingSystem
{
    class Bank
    {
        private List<Account> _accounts;
        private List<Transaction> _transactions;

        public int TransactionCount { get { return _transactions.Count; } }

        public Bank()
        {
            _accounts = new List<Account>();
            _transactions = new List<Transaction>();
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public Account GetAccount(string name)
        {
            foreach (Account account in _accounts)
            {
                if (account.Name == name)
                    return account;
            }
            return null;
        }

        // Accepts any Transaction subtype — polymorphism means one method handles all transaction types
        public void ExecuteTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            transaction.Execute();
        }

        public void RollbackTransaction(Transaction transaction)
        {
            transaction.Rollback();
        }

        public void PrintTransactionHistory()
        {
            if (_transactions.Count == 0)
            {
                Console.WriteLine("No transactions recorded.");
                return;
            }

            Console.WriteLine("=== Transaction History ===");
            for (int i = 0; i < _transactions.Count; i++)
            {
                Console.WriteLine("[" + (i + 1) + "]");
                _transactions[i].Print();
                Console.WriteLine();
            }
        }

        // 1-based index to match the numbers displayed in PrintTransactionHistory
        public Transaction GetTransaction(int index)
        {
            if (index < 1 || index > _transactions.Count)
                return null;
            return _transactions[index - 1];
        }
    }
}