using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game where you will attempt to guess my secret number betwen 1 and 100");
            Console.WriteLine("Choose a difficulty:\n\teasy (8 guesses) \n\tmedium (6) \n\thard (4) \n\tcheater (infinite)");

            string difficulty = Console.ReadLine();
            int chances = 0;

            while (chances == 0)
            {
                switch (difficulty)
                {
                    case "easy":
                        chances = 8;
                        break;
                    case "medium":
                        chances = 6;
                        break;
                    case "hard":
                        chances = 4;
                        break;
                    case "cheater":
                        chances = 1;
                        break;
                    default:
                        Console.Write("Invalid input. Please choose a difficulty by typing easy, medium, hard, or cheater: ");
                        difficulty = Console.ReadLine();
                        break;
                }
            }

            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            while (chances > 0)
            {
                Console.Write($"You have {chances} guess(es) left. What is your guess? Guess: ");
                if (difficulty != "cheater")
                {
                    chances--;
                }

                string guess = Console.ReadLine();

                if (!int.TryParse(guess, out int guessNumber) || guessNumber < 1 || guessNumber > 100)
                {
                    Console.WriteLine("Invalid guess. Please enter a number between 1 and 100.");
                    chances++;
                    continue;
                }


                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else if (guessNumber > randomNumber)
                {
                    Console.WriteLine("You failed... Your guess was too high!");
                }
                else
                {
                    Console.WriteLine("You failed... Your guess was too low!");
                }
            }
        }
    }
}
