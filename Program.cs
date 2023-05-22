using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to guess my secret number?");
            string guess = Console.ReadLine();
            Console.WriteLine(guess);
        }
    }
}
