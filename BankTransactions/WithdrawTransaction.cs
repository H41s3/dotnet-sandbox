using System;

namespace BankingSystem
{
    class WithdrawTransaction
    {
        private Account _account;
        private decimal _amount;
        private bool _executed;
        private bool _success;
        private bool _reversed;

        public bool Executed { get { return _executed; } }
        public bool Success { get { return _success; } }
        public bool Reversed { get { return _reversed; } }

        public WithdrawTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
            _executed = false;
            _success = false;
            _reversed = false;
        }

        public void Print()
        {
            Console.WriteLine("Withdraw Transaction:");
            Console.WriteLine("  Account: " + _account.Name);
            Console.WriteLine("  Amount:  $" + _amount.ToString("F2"));

            if (!_executed)
                Console.WriteLine("  Status:  Not yet executed.");
            else if (_reversed)
                Console.WriteLine("  Status:  Reversed.");
            else if (_success)
                Console.WriteLine("  Status:  Successful.");
            else
                Console.WriteLine("  Status:  Failed.");
        }

        public void Execute()
        {
            // Idempotency guard — transactions are single-use by design
            if (_executed)
                throw new InvalidOperationException("Transaction has already been executed.");

            // Mark executed before the attempt so a crash mid-operation still
            // prevents a retry from running twice
            _executed = true;

            if (!_account.Withdraw(_amount))
                throw new InvalidOperationException("Insufficient funds in account.");

            _success = true;
        }

        public void Rollback()
        {
            // Nothing to undo if the original operation never completed
            if (!_success)
                throw new InvalidOperationException("Cannot rollback: transaction was not successful.");

            if (_reversed)
                throw new InvalidOperationException("Cannot rollback: transaction has already been reversed.");

            _account.Deposit(_amount);
            _reversed = true;
        }
    }
}