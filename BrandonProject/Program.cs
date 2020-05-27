using System;



namespace BrandonProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 0 and 10000 in as few guesses as possible: ");
            string input = Console.ReadLine();
            int userInput = int.Parse(input);

            Random number = new Random();

            int goalNumber = number.Next(0, 10000);

            int numberOfGuesses = 0;

           

            while (userInput > goalNumber || userInput < goalNumber)
            {

                if (userInput < goalNumber)
                {
                    Console.WriteLine("Your guess is too low, guess again: ");
                    string guessLower = Console.ReadLine();
                    int guessLowerNext = int.Parse(guessLower);
                    userInput = guessLowerNext;
                    numberOfGuesses++;
                }

                if (userInput > goalNumber)
                {
                    Console.WriteLine("Your guess is too high, guess again: ");
                    string guessHigher = Console.ReadLine();
                    int guessHigherNext = int.Parse(guessHigher);
                    userInput = guessHigherNext;
                    numberOfGuesses++;
                }

               

                if (userInput == goalNumber)
                {
                    numberOfGuesses++;
                    Console.WriteLine("You guessed the number in " + numberOfGuesses + " guesses!");
                }

            }
            
            Console.ReadLine();


        }
    }
}
