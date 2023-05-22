using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretNumber = "12";
            for (int chances = 1; chances <= 4; chances++)
            {
                Console.WriteLine("Would you like to guess my secret number?");
                string guess = Console.ReadLine();
                if (guess == secretNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else
                {
                    Console.WriteLine("You failed...");
                }
            }
        }
    }
}
