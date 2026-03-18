using System;

class GuessingNumber
{
    static void Main(string[] args)
    {
        // Task says: create a variable called number and set it to 5
        int number = 5;
        int guess = 0;

        // Keep prompting until they get it right
        do
        {
            Console.Write("Guess a number between 1 and 10: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess == number)
            {
                Console.WriteLine("You have guessed the number! Well done!");
            }
            else
            {
                Console.WriteLine("Wrong! Try again.");
            }

        } while (guess != number);
    }
}