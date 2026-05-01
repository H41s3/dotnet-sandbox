using System;

namespace BankingSystem
{
    abstract class Transaction
    {
        // protected so derived classes can access these fields directly
        protected decimal _amount;
        protected bool _success;
        protected bool _executed;
        protected bool _reversed;
        protected DateTime _datestamp;

        public bool Executed { get { return _executed; } }
        public bool Reversed { get { return _reversed; } }
        public DateTime DateStamp { get { return _datestamp; } }

        // Abstract: each derived class defines what "Success" means for it
        public abstract bool Success { get; }

        public Transaction(decimal amount)
        {
            _amount = amount;
            _success = false;
            _executed = false;
            _reversed = false;
        }

        // Abstract: each derived class provides its own Print implementation
        public abstract void Print();

        // Virtual: derived classes call base.Execute() first, then do their work
        public virtual void Execute()
        {
            _executed = true;
            _datestamp = DateTime.Now;
        }

        // Virtual: derived classes call base.Rollback() first, then do their work
        public virtual void Rollback()
        {
            _reversed = true;
            _datestamp = DateTime.Now;
        }
    }
}