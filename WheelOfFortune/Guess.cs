using System;

namespace wof
{
    public class Guess
    {
        public Guess()
        {
            Console.WriteLine("\nUser, guess a letter: ");
            MakeGuess();
        }

        private void MakeGuess()
        {
            var guess = Console.ReadKey();
            if (guess.Key >= ConsoleKey.A && guess.Key <= ConsoleKey.Z)
            {
                Program.round.GuessLetter(guess.Key);
            }
            else
            {
                Console.WriteLine("Invalid character.");
            }

        }
    }
}
