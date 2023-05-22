using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            Console.WriteLine(randomNumber.ToString());
            for (int chances = 1; chances <= 4; chances++)
            {
                if (chances == 1)
                {
                    Console.WriteLine("Would you like to guess my secret number? I'll give you four guesses");
                }
                else
                {
                    string prompt = "";
                    switch (chances)
                    {
                        case 2:
                            prompt = "three";
                            break;
                        case 3:
                            prompt = "two";
                            break;
                        case 4:
                            prompt = "one";
                            break;
                        default:
                            // code block
                            break;
                    }
                    Console.WriteLine($"You have {prompt} guess(es) left. What is your next guess?");
                }
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
