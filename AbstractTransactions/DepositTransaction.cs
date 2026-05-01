using System;

namespace BankingSystem
{
    class DepositTransaction : Transaction
    {
        private Account _account;

        public override bool Success { get { return _success; } }

        public DepositTransaction(Account account, decimal amount) : base(amount)
        {
            _account = account;
        }

        public override void Print()
        {
            Console.WriteLine("Deposit Transaction:");
            Console.WriteLine("  Account:   " + _account.Name);
            Console.WriteLine("  Amount:    $" + _amount.ToString("F2"));
            Console.WriteLine("  Timestamp: " + _datestamp.ToString("g"));
            if (!_executed)
                Console.WriteLine("  Status:    Not yet executed.");
            else if (_reversed)
                Console.WriteLine("  Status:    Reversed.");
            else if (_success)
                Console.WriteLine("  Status:    Successful.");
            else
                Console.WriteLine("  Status:    Failed.");
        }

        public override void Execute()
        {
            if (_executed)
                throw new InvalidOperationException("Transaction has already been executed.");

            base.Execute();

            bool result = _account.Deposit(_amount);
            if (!result)
                throw new InvalidOperationException("Deposit failed: amount must be greater than zero.");

            _success = true;
        }

        public override void Rollback()
        {
            if (!_success)
                throw new InvalidOperationException("Cannot rollback: transaction was not successful.");
            if (_reversed)
                throw new InvalidOperationException("Cannot rollback: transaction has already been reversed.");

            // Reversing a deposit requires the account to have enough funds —
            // another transaction may have withdrawn the money in the meantime
            bool result = _account.Withdraw(_amount);
            if (!result)
                throw new InvalidOperationException("Cannot rollback: account has insufficient funds to reverse deposit.");

            base.Rollback();
        }
    }
}