using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game where you will attempt to guess my secret number betwen 1 and 100");
            Console.WriteLine("Choose a difficulty by typing easy, medium, or hard: easy (8 guesses), medium (6), hard (4)");
            string difficulty = Console.ReadLine();
            int chances = 0;
            while (chances == 0)
            {
                if (difficulty == "easy")
                {
                    chances = 8;
                }
                else if (difficulty == "medium")
                {
                    chances = 6;
                }
                else if (difficulty == "hard")
                {
                    chances = 4;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please choose a difficulty by typing easy, medium, or hard:");
                    difficulty = Console.ReadLine();
                }
            }
            int runningChances = chances;
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            Console.WriteLine(randomNumber.ToString());
            while (runningChances > 0)
            {
                if (runningChances == chances)
                {
                    Console.WriteLine($"Okay. I'll give you {chances} guesses");
                }
                else
                {
                    Console.WriteLine($"You have {runningChances} guess(es) left. What is your next guess?");
                }
                runningChances--;
                string guess = Console.ReadLine();
                int guessNumber = Int16.Parse(guess);
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
