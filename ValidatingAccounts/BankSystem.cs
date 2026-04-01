// BankSystem.cs - Main program: provides the UI for controlling a bank account

using System;

namespace BankingSystem
{
    // Enumeration for the menu options.
    // Enums start at 0 by default, so: Withdraw=0, Deposit=1, Print=2, Quit=3.
    // This maps neatly to the user entering 1-4 (we subtract 1 to convert).
    enum MenuOption
    {
        Withdraw,   // 0
        Deposit,    // 1
        Print,      // 2
        Quit        // 3
    }

    class BankSystem
    {
        // Displays the menu and reads a valid option from the user.
        // Uses a do-while so the menu always shows at least once.
        static MenuOption ReadUserOption()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Banking Menu ---");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Print");
                Console.WriteLine("4. Quit");
                Console.Write("Enter your choice (1-4): ");

                // Read input and convert to integer
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice < 1 || choice > 4)
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");

            } while (choice < 1 || choice > 4); // keep looping until valid

            // Subtract 1 because enum starts at 0, menu starts at 1
            return (MenuOption)(choice - 1);
        }

        // Asks the user for a deposit amount and attempts the deposit
        static void DoDeposit(Account account)
        {
            Console.Write("Enter amount to deposit: $");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            bool success = account.Deposit(amount);

            if (success)
                Console.WriteLine("Deposit successful.");
            else
                Console.WriteLine("Deposit failed. Amount must be greater than zero.");
        }

        // Asks the user for a withdrawal amount and attempts the withdrawal
        static void DoWithdraw(Account account)
        {
            Console.Write("Enter amount to withdraw: $");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            bool success = account.Withdraw(amount);

            if (success)
                Console.WriteLine("Withdrawal successful.");
            else
                Console.WriteLine("Withdrawal failed. Amount must be positive and not exceed your balance.");
        }

        // Prints the current account details
        static void DoPrint(Account account)
        {
            account.Print();
        }

        static void Main(string[] args)
        {
            // Create a test account to work with
            Account myAccount = new Account("Taro Tanaka", 1000.00m);

            Console.WriteLine("Welcome to the Banking System!");

            MenuOption option;

            // Keep showing the menu until the user chooses Quit
            do
            {
                option = ReadUserOption();

                switch (option)
                {
                    case MenuOption.Withdraw:
                        Console.WriteLine("You selected: Withdraw");
                        DoWithdraw(myAccount);
                        break;

                    case MenuOption.Deposit:
                        Console.WriteLine("You selected: Deposit");
                        DoDeposit(myAccount);
                        break;

                    case MenuOption.Print:
                        Console.WriteLine("You selected: Print");
                        DoPrint(myAccount);
                        break;

                    case MenuOption.Quit:
                        Console.WriteLine("You selected: Quit");
                        Console.WriteLine("Goodbye!");
                        break;
                }

            } while (option != MenuOption.Quit);
        }
    }
}