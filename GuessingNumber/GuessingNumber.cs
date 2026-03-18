using System;

// SIT232 - Practical Task 1.2
// Task 6: Number guessing game with input validation
// User 1 sets the secret number, User 2 guesses it

class GuessingNumber
{
    static void Main(string[] args)
    {
        int secretNumber = 0;
        int guess = 0;
        bool validInput;

        Console.WriteLine("=== Number Guessing Game ===\n");

        // =============================================
        // USER 1: Set the secret number (validated)
        // do...while is perfect here — we MUST get at least one input
        // =============================================
        Console.WriteLine("User 1: Enter a secret number between 1 and 10.");

        do
        {
            Console.Write("Enter number: ");
            string input1 = Console.ReadLine();

            // TryParse safely converts string to int — returns false if it fails
            validInput = int.TryParse(input1, out secretNumber);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
            }
            else if (secretNumber < 1 || secretNumber > 10)
            {
                Console.WriteLine("Out of range. Must be between 1 and 10.");
                validInput = false; // force the loop to repeat
            }

        } while (!validInput); // keep asking until we get a valid number

        Console.WriteLine("\nSecret number set! Now User 2 will guess.\n");

        // =============================================
        // USER 2: Guess until correct (with validation)
        // =============================================
