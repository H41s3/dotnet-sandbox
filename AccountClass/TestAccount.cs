using System;

namespace Account
{
    class TestAccount
    {
        public static void Main()
        {
            Account myAccount = new Account("Alice", 1000m);
            myAccount.Deposit(500);
            myAccount.Withdraw(200);
            myAccount.Print();
        }
    }
}