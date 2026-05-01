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
            TransactionHistory = 6,
            Quit = 7
        }

        static MenuOption ReadUserOption()
        {
            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("=== Bank Menu ===");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Print Account Details");
                Console.WriteLine("6. Transaction History");
                Console.WriteLine("7. Quit");
                Console.Write("Choose an option: ");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7);

            return (MenuOption)choice;
        }

        static void DoAddAccount(Bank bank)
        {
            Console.Write("Enter account name: ");
            string name = Console.ReadLine();

            decimal balance;
            do
            {
                Console.Write("Enter opening balance: $");
            }
            while (!decimal.TryParse(Console.ReadLine(), out balance) || balance < 0);

            bank.AddAccount(new Account(name, balance));
            Console.WriteLine("Account added.");
        }

        static void DoDeposit(Bank bank)
        {
            Console.Write("Enter account name: ");
            Account account = bank.GetAccount(Console.ReadLine());

            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            decimal amount;
            do
            {
                Console.Write("Enter deposit amount: $");
            }
            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0);

            DepositTransaction transaction = new DepositTransaction(account, amount);

            try
            {
                bank.ExecuteTransaction(transaction);
                Console.WriteLine("Deposit successful.");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Deposit error: " + e.Message);
            }
        }

        static void DoWithdraw(Bank bank)
        {
            Console.Write("Enter account name: ");
            Account account = bank.GetAccount(Console.ReadLine());

            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            decimal amount;
            do
            {
                Console.Write("Enter withdrawal amount: $");
            }
            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0);

            WithdrawTransaction transaction = new WithdrawTransaction(account, amount);

            try
            {
                bank.ExecuteTransaction(transaction);
                Console.WriteLine("Withdrawal successful.");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Withdrawal error: " + e.Message);
            }
        }

        static void DoTransfer(Bank bank)
        {
            Console.Write("Enter source account name: ");
            Account from = bank.GetAccount(Console.ReadLine());

            if (from == null)
            {
                Console.WriteLine("Source account not found.");
                return;
            }

            Console.Write("Enter destination account name: ");
            Account to = bank.GetAccount(Console.ReadLine());

            if (to == null)
            {
                Console.WriteLine("Destination account not found.");
                return;
            }

            decimal amount;
            do
            {
                Console.Write("Enter transfer amount: $");
            }
            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0);

            TransferTransaction transaction = new TransferTransaction(from, to, amount);

            try
            {
                bank.ExecuteTransaction(transaction);
                Console.WriteLine("Transfer successful.");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Transfer error: " + e.Message);
            }
        }

        static void DoPrint(Bank bank)
        {
            Console.Write("Enter account name: ");
            Account account = bank.GetAccount(Console.ReadLine());

            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            account.Print();
        }

        static void DoRollback(Bank bank)
        {
            bank.PrintTransactionHistory();

            if (bank.TransactionCount == 0)
                return;

            Console.Write("Enter transaction number to rollback (or 0 to cancel): ");
            int index;
            if (!int.TryParse(Console.ReadLine(), out index) || index == 0)
                return;

            Transaction transaction = bank.GetTransaction(index);

            if (transaction == null)
            {
                Console.WriteLine("Invalid transaction number.");
                return;
            }

            try
            {
                bank.RollbackTransaction(transaction);
                Console.WriteLine("Rollback successful.");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Rollback error: " + e.Message);
            }
        }

        static void Main(string[] args)
        {
            Bank bank = new Bank();

            bank.AddAccount(new Account("Taro Sakamoto", 1000.00m));
            bank.AddAccount(new Account("Alex Johnson", 500.00m));

            Console.WriteLine("Welcome to the Banking System!");

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

                    case MenuOption.TransactionHistory:
                        DoRollback(bank);
                        break;

                    case MenuOption.Quit:
                        Console.WriteLine("Goodbye!");
                        break;
                }
            }
            while (option != MenuOption.Quit);
        }
    }
}