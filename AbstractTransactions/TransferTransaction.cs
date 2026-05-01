using System;

namespace BankingSystem
{
    class TransferTransaction : Transaction
    {
        private Account _fromAccount;
        private Account _toAccount;
        private DepositTransaction _deposit;
        private WithdrawTransaction _withdraw;

        // Both sub-transactions must succeed for the transfer to be considered successful
        public override bool Success
        {
            get { return _withdraw.Success && _deposit.Success; }
        }

        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount) : base(amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _withdraw = new WithdrawTransaction(fromAccount, amount);
            _deposit = new DepositTransaction(toAccount, amount);
        }

        public override void Print()
        {
            Console.WriteLine("Transfer Transaction:");
            Console.WriteLine("  From:      " + _fromAccount.Name);
            Console.WriteLine("  To:        " + _toAccount.Name);
            Console.WriteLine("  Amount:    $" + _amount.ToString("F2"));
            Console.WriteLine("  Timestamp: " + _datestamp.ToString("g"));
            if (!_executed)
                Console.WriteLine("  Status:    Not yet executed.");
            else if (_reversed)
                Console.WriteLine("  Status:    Reversed.");
            else if (Success)
                Console.WriteLine("  Status:    Successful.");
            else
                Console.WriteLine("  Status:    Failed.");
        }

        public override void Execute()
        {
            if (_executed)
                throw new InvalidOperationException("Transaction has already been executed.");

            base.Execute();

            try
            {
                _withdraw.Execute();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Transfer failed: insufficient funds in source account.");
            }

            // If the deposit fails after a successful withdrawal, roll back the withdrawal
            // so the source account is not left in a partially modified state
            try
            {
                _deposit.Execute();
            }
            catch (InvalidOperationException)
            {
                _withdraw.Rollback();
                throw new InvalidOperationException("Transfer failed: could not deposit into destination account.");
            }
        }

        public override void Rollback()
        {
            if (!Success)
                throw new InvalidOperationException("Cannot rollback: transfer was not successful.");
            if (_reversed)
                throw new InvalidOperationException("Cannot rollback: transfer has already been reversed.");

            // Reverse in opposite order to execution — deposit first, then withdrawal
            _deposit.Rollback();
            _withdraw.Rollback();
            base.Rollback();
        }
    }
}