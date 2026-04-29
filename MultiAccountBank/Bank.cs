using System;
using System.Collections.Generic;

namespace BankingSystem
{
    class Bank
    {
        // The private list that holds all accounts belonging to this bank
        private List<Account> _accounts;

        // Constructor — starts with an empty list of accounts
        public Bank()
        {
            _accounts = new List<Account>();
        }

        // Adds the given account to the bank's internal list
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        // Searches through all accounts and returns the one whose name matches
        // Returns null if no account with that name exists
        public Account GetAccount(string name)
        {
            foreach (Account account in _accounts)
            {
                if (account.Name == name)
                    return account;
            }
            return null;
        }

        // Method overloading — three versions of ExecuteTransaction, one per type
        // The compiler picks the right version based on what gets passed in

        // Runs a deposit transaction
        public void ExecuteTransaction(DepositTransaction transaction)
        {
            transaction.Execute();
        }

        // Runs a withdrawal transaction
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            transaction.Execute();
        }

        // Runs a transfer transaction
        public void ExecuteTransaction(TransferTransaction transaction)
        {
            transaction.Execute();
        }
    }
}