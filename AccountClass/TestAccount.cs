using System;

// Same namespace as Account.cs so both classes can find each other
namespace BankingSystem
{
    // TestAccount acts as the driver — it tests the Account class functionality
    class TestAccount
    {
        // Main is the entry point — this is where the program starts running
        public static void Main()
        {
            // Create a new Account object with name "Alice" and initial balance of $1000
            Account myAccount = new Account("Alice", 1000m);

            // Test Deposit — adds $500 to the account
            myAccount.Deposit(500m);

            // Test Withdraw — removes $200 from the account
            myAccount.Withdraw(200m);

            // Print final account details to the terminal
            myAccount.Print();
        }
    }
}