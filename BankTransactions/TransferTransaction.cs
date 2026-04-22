using System;

namespace BankingSystem
{
    class DepositTransaction
    {
        private Account _account;
        private decimal _amount;
        private bool _executed;
        private bool _success;
        private bool _reversed;

        public bool Executed { get { return _executed; } }
        public bool Success { get { return _success; } }
        public bool Reversed { get { return _reversed; } }

        public DepositTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
            _executed = false;
            _success = false;
            _reversed = false;
        }

        public void Print()
        {
            Console.WriteLine("Deposit Transaction:");
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
            if (_executed)
                throw new InvalidOperationException("Transaction has already been executed.");

            _executed = true;

            if (!_account.Deposit(_amount))
                throw new InvalidOperationException("Deposit failed: amount must be greater than zero.");

            _success = true;
        }

        public void Rollback()
        {
            if (!_success)
                throw new InvalidOperationException("Cannot rollback: transaction was not successful.");

            if (_reversed)
                throw new InvalidOperationException("Cannot rollback: transaction has already been reversed.");

            // Rollback of a deposit requires withdrawing the funds back out.
            // This can fail if the account has since spent the money — that's
            // a legitimate runtime condition, not a bug.
            if (!_account.Withdraw(_amount))
                throw new InvalidOperationException("Cannot rollback: account has insufficient funds to reverse the deposit.");

            _reversed = true;
        }
    }
}