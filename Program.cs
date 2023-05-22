using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            RunGame();
        }

        static void RunGame()
        {
            Console.WriteLine("Welcome to the Guessing Game! I have a secret number between 1 and 100.");
            Console.WriteLine("Choose a difficulty: easy (8 guesses), medium (6), hard (4), or cheater (infinite guesses).");
            string difficulty = Console.ReadLine();

            int chances = GetChances(difficulty);
            if (chances == 0)
            {
                Console.WriteLine("Invalid input. Please choose a difficulty by typing easy, medium, hard, or cheater.");
                RunGame();
                return;
            }

            PlayGame(chances);

            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgainInput = Console.ReadLine();
            playAgainInput = playAgainInput.ToLower();
            while (playAgainInput != "yes" && playAgainInput != "no")
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                playAgainInput = Console.ReadLine();
                playAgainInput = playAgainInput.ToLower();
            }

            if (playAgainInput == "yes")
            {
                RunGame();
            }
        }

        static int GetChances(string difficulty)
        {
            switch (difficulty)
            {
                case "easy":
                    return 8;
                case "medium":
                    return 6;
                case "hard":
                    return 4;
                case "cheater":
                    return int.MaxValue;
                default:
                    return 0;
            }
        }

        static void PlayGame(int chances)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine("I've picked my secret number. Start guessing!");

            for (int i = 0; i < chances; i++)
            {
                Console.WriteLine($"You have {chances - i} guess(es) left. What is your next guess?");
                string guess = Console.ReadLine();

                if (!int.TryParse(guess, out int guessNumber) || guessNumber < 1 || guessNumber > 100)
                {
                    Console.WriteLine("Invalid guess. Please enter a number between 1 and 100.");
                    i--;
                    continue;
                }

                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("You guessed it!");
                    return;
                }
                else if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Your guess was too high!");
                }
                else
                {
                    Console.WriteLine("Your guess was too low!");
                }
            }

            Console.WriteLine($"Sorry, you ran out of guesses. The secret number was {randomNumber}.");
        }
    }
}
