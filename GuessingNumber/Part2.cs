using System;

class GuessingNumber
{
    static void Main(string[] args)
    {
        int secretNumber = 0;
        int guess = 0;
        bool validInput;

        // USER 1: set the secret number with validation
        Console.WriteLine("User 1: Enter a secret number between 1 and 10.");

        do
        {
            Console.Write("Enter number: ");
            string input1 = Console.ReadLine();

            validInput = int.TryParse(input1, out secretNumber);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
            }
            else if (secretNumber < 1 || secretNumber > 10)
            {
                Console.WriteLine("Out of range. Must be between 1 and 10.");
                validInput = false;
            }

        } while (!validInput);

        Console.WriteLine("\nSecret number set! Now User 2 will guess.\n");

        // USER 2: guess until correct with validation
        int attempts = 0;

        do
        {
            Console.Write("User 2 - Guess a number between 1 and 10: ");
            string input2 = Console.ReadLine();

            validInput = int.TryParse(input2, out guess);

            if (!validInput)
            {
                Console.WriteLine("That's not a valid number. Try again.");
                continue;
            }

            if (guess < 1 || guess > 10)
            {
                Console.WriteLine("Out of range! Must be between 1 and 10.");
                continue;
            }

            attempts++;

            if (guess == secretNumber)
            {
                Console.WriteLine("You have guessed the number! Well done!");
                Console.WriteLine("It took you " + attempts + " attempt(s).");
            }
            else
            {
                Console.WriteLine("Wrong! Try again.");
            }

        } while (guess != secretNumber);
    }
}