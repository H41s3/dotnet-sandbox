using System;

namespace BankingSystem
{
    class TransferTransaction
    {
        private Account _fromAccount;
        private Account _toAccount;
        private decimal _amount;

        // Delegate to dedicated transaction objects rather than reimplementing
        // withdraw/deposit logic — keeps each class responsible for one thing
        private WithdrawTransaction _withdraw;
        private DepositTransaction _deposit;

        private bool _executed;
        private bool _reversed;

        public bool Executed { get { return _executed; } }
        public bool Reversed { get { return _reversed; } }

        // Derived from sub-transactions — no separate field needed since
        // the transfer only succeeds when both halves succeed
        public bool Success
        {
            get { return _withdraw.Success && _deposit.Success; }
        }

        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;

            // Build sub-transactions at construction time so they're ready to execute
            _withdraw = new WithdrawTransaction(fromAccount, amount);
            _deposit = new DepositTransaction(toAccount, amount);

            _executed = false;
            _reversed = false;
        }

        public void Print()
        {
            Console.WriteLine("Transfer Transaction:");
            Console.WriteLine("  Transferred $" + _amount.ToString("F2") +
                              " from " + _fromAccount.Name +
                              "'s account to " + _toAccount.Name + "'s account.");
            _withdraw.Print();
            _deposit.Print();
        }

        public void Execute()
        {
            if (_executed)
                throw new InvalidOperationException("Transfer transaction has already been executed.");

            _executed = true;

            // Withdraw first — if this throws (e.g. insufficient funds),
            // the deposit never runs and no money leaves either account
            _withdraw.Execute();
            _deposit.Execute();
        }

        public void Rollback()
        {
            if (!Success)
                throw new InvalidOperationException("Cannot rollback: transfer was not fully successful.");

            if (_reversed)
                throw new InvalidOperationException("Cannot rollback: transfer has already been reversed.");

            // Reverse in opposite order to Execute — undo deposit first, then
            // restore the source account. If deposit rollback fails (toAccount
            // has spent the funds), the source account remains untouched.
            _deposit.Rollback();
            _withdraw.Rollback();

            _reversed = true;
        }
    }
}