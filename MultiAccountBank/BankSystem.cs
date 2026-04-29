using System;

namespace BankingSystem
{
    class BankSystem
    {
        enum MenuOption
        {
            AddAccount = 1,
            Deposit = 2,
            Withdraw = 3,
            Transfer = 4,
            Print = 5,
            Quit = 6
        }

        // Displays the menu and reads a valid option from the user
        static MenuOption ReadUserOption()
        {
            int choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("=== Bank Menu ===");
                Console.WriteLine("1. Add new account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Print account");
                Console.WriteLine("6. Quit");
                Console.Write("Enter choice (1-6): ");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out choice) || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 6.");
                    choice = 0;
                }

            } while (choice < 1 || choice > 6);

            return (MenuOption)choice;
        }

        // Asks the user for an account name and looks it up in the bank.
        // Returns the account (or null if not found) and notifies the user either way.
        static Account FindAccount(Bank bank)
        {
            Console.Write("Enter account name: ");
            string name = Console.ReadLine();

            Account account = bank.GetAccount(name);

            if (account == null)
                Console.WriteLine($"No account found with the name \"{name}\".");

            return account;
        }

        // Creates a new account and adds it to the bank
        static void DoAddAccount(Bank bank)
        {
            Console.Write("Enter account name: ");
            string name = Console.ReadLine();

            Console.Write("Enter starting balance: $");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            Account account = new Account(name, balance);
            bank.AddAccount(account);

            Console.WriteLine($"Account \"{name}\" created with balance ${balance:F2}.");
        }

        // Deposits into whichever account the user names
        static void DoDeposit(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account == null) return;

            Console.Write("Enter amount to deposit: $");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            DepositTransaction transaction = new DepositTransaction(account, amount);

            try
            {
                bank.ExecuteTransaction(transaction);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Deposit error: " + e.Message);
            }

            transaction.Print();
        }

        // Withdraws from whichever account the user names
        static void DoWithdraw(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account == null) return;

            Console.Write("Enter amount to withdraw: $");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            WithdrawTransaction transaction = new WithdrawTransaction(account, amount);

            try
            {
                bank.ExecuteTransaction(transaction);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Withdrawal error: " + e.Message);
            }

            transaction.Print();
        }

        // Transfers between two named accounts — both must exist
        static void DoTransfer(Bank bank)
        {
            Console.WriteLine("Source account (money comes FROM here):");
            Account fromAccount = FindAccount(bank);
            if (fromAccount == null) return;

            Console.WriteLine("Destination account (money goes TO here):");
            Account toAccount = FindAccount(bank);
            if (toAccount == null) return;

            Console.Write("Enter amount to transfer: $");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            TransferTransaction transaction = new TransferTransaction(fromAccount, toAccount, amount);

            try
            {
                bank.ExecuteTransaction(transaction);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Transfer error: " + e.Message);
            }

            transaction.Print();
        }

        // Prints the details of a named account
        static void DoPrint(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account == null) return;

            account.Print();
        }

        // Entry point — creates the bank and runs the menu loop
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            MenuOption option;

            do
            {
                option = ReadUserOption();

                switch (option)
                {
                    case MenuOption.AddAccount:
                        DoAddAccount(bank);
                        break;
                    case MenuOption.Deposit:
                        DoDeposit(bank);
                        break;
                    case MenuOption.Withdraw:
                        DoWithdraw(bank);
                        break;
                    case MenuOption.Transfer:
                        DoTransfer(bank);
                        break;
                    case MenuOption.Print:
                        DoPrint(bank);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Goodbye!");
                        break;
                }

            } while (option != MenuOption.Quit);
        }
    }
}