using System;

namespace BankingSystem
{
    // Abstract base class — cannot be instantiated directly.
    // DepositTransaction, WithdrawTransaction, and TransferTransaction all inherit from this.
    abstract class Transaction
    {
        // protected means these fields are visible to this class and any class that inherits from it,
        // but not to anything outside the inheritance hierarchy
        protected decimal _amount;
        protected bool _success;
        protected bool _executed;
        protected bool _reversed;
        protected DateTime _datestamp;  // records when Execute or Rollback was last called

        public bool Executed { get { return _executed; } }
        public bool Reversed { get { return _reversed; } }
        public DateTime DateStamp { get { return _datestamp; } }

        // Abstract property — each derived class must define what "Success" means for that transaction
        public abstract bool Success { get; }

        // Sets the amount — called by derived class constructors via base(amount)
        public Transaction(decimal amount)
        {
            _amount = amount;
            _success = false;
            _executed = false;
            _reversed = false;
        }

        // Abstract method — each derived class must provide its own Print implementation
        public abstract void Print();

        // Virtual Execute — stamps the time and marks the transaction as executed.
        // Derived classes call base.Execute() first, then carry out the actual banking logic.
        public virtual void Execute()
        {
            _executed = true;
            _datestamp = DateTime.Now;
        }

        // Virtual Rollback — stamps the time and marks the transaction as reversed.
        // Derived classes call base.Rollback() after completing their reversal logic.
        public virtual void Rollback()
        {
            _reversed = true;
            _datestamp = DateTime.Now;
        }
    }
}