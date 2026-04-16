using System;

namespace ExceptionHandling
{
    class Program
    {
        public static void Main()
        {
            // 1. NullReferenceException
            try
            {
                string text = null;
                Console.WriteLine(text.Length);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            // 2. IndexOutOfRangeException
            try
            {
                int[] numbers = new int[3];
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            // 6. ArgumentNullException
            try
            {
                string name = null;
                if (name == null)
                    throw new ArgumentNullException("name", "Name cannot be null.");
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            // 7. ArgumentOutOfRangeException
            try
            {
                int age = -1;
                if (age < 0)
                    throw new ArgumentOutOfRangeException("age", age, "Age cannot be negative.");
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            // 8. FormatException
            try
            {
                int number = int.Parse("abc");
            }
            catch (FormatException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            // 9. ArgumentException
            try
            {
                string scale = "K";
                if (scale != "C" && scale != "F")
                    throw new ArgumentException("Invalid scale. Expected C or F.", "scale");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            // 10. SystemException - base class for runtime exceptions

            // InvalidOperationException example provided in the task
            try
            {
                Account account = new Account("Sergey", "P", 100);
                account.Withdraw(1000);
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            Console.ReadKey();
        }
    }

    class Account
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Balance { get; private set; }

        public Account(string firstName, string lastName, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public void Withdraw(int amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient fund");
            }
            Balance = Balance - amount;
        }
    }
}