using System;

namespace BankingSystem
{
    enum MenuOption
    {
        Withdraw,   // 0
        Deposit,    // 1
        Print,      // 2
        Transfer,   // 3
        Quit        // 4
    }

    class BankSystem
    {
        static MenuOption ReadUserOption()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--Banking Menu--");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Print");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice (1-5): ");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice < 1 || choice > 5)
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");

            } while (choice < 1 || choice > 5);

            return (MenuOption)(choice - 1);
        }

        static void DoDeposit(Account account)
        {
            Console.Write("Enter amount to deposit: $");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            DepositTransaction transaction = new DepositTransaction(account, amount);

            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Deposit error: " + e.Message);
            }

            transaction.Print();
        }

        static void DoWithdraw(Account account)
        {
            Console.Write("Enter amount to withdraw: $");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            WithdrawTransaction transaction = new WithdrawTransaction(account, amount);

            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Withdrawal error: " + e.Message);
            }

            transaction.Print();
        }

        static void DoTransfer(Account firstAccount, Account secondAccount)
        {
            Console.WriteLine("Transfer from:");
            Console.WriteLine("  1. " + firstAccount.Name);
            Console.WriteLine("  2. " + secondAccount.Name);
            Console.Write("Choose source account (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Account from = (choice == 1) ? firstAccount : secondAccount;
            Account to = (choice == 1) ? secondAccount : firstAccount;

            Console.Write("Enter amount to transfer: $");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            TransferTransaction transaction = new TransferTransaction(from, to, amount);

            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Transfer error: " + e.Message);
            }

            transaction.Print();
        }

        static void DoPrint(Account account)
        {
            account.Print();
        }

        static void Main(string[] args)
        {
            Account accountA = new Account("Taro Sakamoto", 1000.00m);
            Account accountB = new Account("Alex Johnson", 500.00m);

            Console.WriteLine("Welcome to the Banking System!");
            Console.WriteLine("Account A: " + accountA.Name + " | Account B: " + accountB.Name);

            MenuOption option;

            do
            {
                option = ReadUserOption();

                switch (option)
                {
                    case MenuOption.Withdraw:
                        Console.WriteLine("You selected: Withdraw");
                        DoWithdraw(accountA);
                        break;

                    case MenuOption.Deposit:
                        Console.WriteLine("You selected: Deposit");
                        DoDeposit(accountA);
                        break;

                    case MenuOption.Print:
                        Console.WriteLine("You selected: Print");
                        DoPrint(accountA);
                        Console.WriteLine();
                        DoPrint(accountB);
                        break;

                    case MenuOption.Transfer:
                        Console.WriteLine("You selected: Transfer");
                        DoTransfer(accountA, accountB);
                        break;

                    case MenuOption.Quit:
                        Console.WriteLine("Goodbye!");
                        break;
                }

            } while (option != MenuOption.Quit);
        }
    }
}