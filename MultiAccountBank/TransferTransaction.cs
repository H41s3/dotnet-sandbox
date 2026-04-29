using System;

namespace BankingSystem
{
    class TransferTransaction
    {
        // The two accounts involved — money moves from _fromAccount to _toAccount
        private Account _fromAccount;
        private Account _toAccount;
        private decimal _amount;

        // Tracks whether this transaction has been run and whether it worked
        private bool _executed;
        private bool _success;

        // A transfer is built from one withdrawal and one deposit internally
        private WithdrawTransaction _withdraw;
        private DepositTransaction _deposit;

        // Read-only properties so outside code can check the transaction status
        public bool Executed => _executed;
        public bool Success => _success;

        // Constructor — sets up both the withdrawal and deposit sub-transactions
        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;
            _executed = false;
            _success = false;
            _withdraw = new WithdrawTransaction(fromAccount, amount);
            _deposit = new DepositTransaction(toAccount, amount);
        }

        // Runs the transfer — first withdraws, then deposits
        // If the deposit fails after a successful withdrawal, the money is returned
        public void Execute()
        {
            if (_executed)
                throw new InvalidOperationException("Transaction has already been executed.");

            _executed = true;

            // step1 try to take money out of the source account
            try
            {
                _withdraw.Execute();
            }
            catch (InvalidOperationException)
            {
                _success = false;
                throw new InvalidOperationException("Transfer failed: could not withdraw from source account.");
            }

            // step2 try to put money into the destination account
            try
            {
                _deposit.Execute();
            }
            catch (InvalidOperationException)
            {
                // Reverse the withdrawal so the money goes back if deposit fails
                _fromAccount.Deposit(_amount);
                _success = false;
                throw new InvalidOperationException("Transfer failed: could not deposit into destination account.");
            }

            _success = true;
        }

        // Prints a summary of the transfer result including both account balances
        public void Print()
        {
            Console.WriteLine("=== Transfer Transaction ===");
            Console.WriteLine($"From:         {_fromAccount.Name}");
            Console.WriteLine($"To:           {_toAccount.Name}");
            Console.WriteLine($"Amount:       ${_amount:F2}");
            Console.WriteLine($"Executed:     {_executed}");
            Console.WriteLine($"Success:      {_success}");
            Console.WriteLine($"From Balance: ${_fromAccount.Balance:F2}");
            Console.WriteLine($"To Balance:   ${_toAccount.Balance:F2}");
        }
    }
}