using System;

namespace BankingSystem
{
    class DepositTransaction
    {
        // The account receiving the money and the amount to deposit
        private Account _account;
        private decimal _amount;

        // Tracks whether this transaction has been run and whether it worked
        private bool _executed;
        private bool _success;

        // Read-only properties so outside code can check the transaction status
        public bool Executed => _executed;
        public bool Success => _success;

        // Constructor — stores the account and amount, marks as not yet executed
        public DepositTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
            _executed = false;
            _success = false;
        }

        // Runs the deposit — throws if already executed or if the deposit fails
        public void Execute()
        {
            if (_executed)
                throw new InvalidOperationException("Transaction has already been executed.");

            _executed = true;
            _success = _account.Deposit(_amount);

            if (!_success)
                throw new InvalidOperationException("Deposit failed: amount must be greater than zero.");
        }

        // Prints a summary of the transaction result
        public void Print()
        {
            Console.WriteLine("=== Deposit Transaction ===");
            Console.WriteLine($"Account:  {_account.Name}");
            Console.WriteLine($"Amount:   ${_amount:F2}");
            Console.WriteLine($"Executed: {_executed}");
            Console.WriteLine($"Success:  {_success}");
            Console.WriteLine($"Balance:  ${_account.Balance:F2}");
        }
    }
}