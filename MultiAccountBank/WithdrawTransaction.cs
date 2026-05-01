using System;

namespace BankingSystem
{
    class WithdrawTransaction
    {
        private Account _account;
        private decimal _amount;
        private bool _executed;
        private bool _success;

        public bool Executed => _executed;
        public bool Success => _success;

        public WithdrawTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
            _executed = false;
            _success = false;
        }

        public void Execute()
        {
            if (_executed)
                throw new InvalidOperationException("Transaction has already been executed.");

            _executed = true;
            _success = _account.Withdraw(_amount);

            if (!_success)
                throw new InvalidOperationException("Withdrawal failed: insufficient funds or invalid amount.");
        }

        public void Print()
        {
            Console.WriteLine("=== Withdraw Transaction ===");
            Console.WriteLine($"Account:  {_account.Name}");
            Console.WriteLine($"Amount:   ${_amount:F2}");
            Console.WriteLine($"Executed: {_executed}");
            Console.WriteLine($"Success:  {_success}");
            Console.WriteLine($"Balance:  ${_account.Balance:F2}");
        }
    }
}