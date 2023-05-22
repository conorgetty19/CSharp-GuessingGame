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
                if (chances == 1)
                {
                    Console.WriteLine("Would you like to guess my secret number?");
                }
                else
                {
                    string prompt = "";
                    switch (chances)
                    {
                        case 2:
                            prompt = "second";
                            break;
                        case 3:
                            prompt = "third";
                            break;
                        case 4:
                            prompt = "fourth";
                            break;
                        default:
                            // code block
                            break;
                    }
                    Console.WriteLine($"What is your {prompt} guess?");
                }
                string guess = Console.ReadLine();
                if (guess == secretNumber)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else
                {
                    Console.WriteLine("You failed...");
                }
            }
        }
    }
}
