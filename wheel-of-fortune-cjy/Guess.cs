using System;

namespace wof
{
    public class Guess
    {

        private int points;

        public Guess()
        {
            Console.WriteLine($"{Program.players[Program.round.playerTurn]}, guess a letter, word, or phrase: ");
            MakeGuess();
        }

        private void MakeGuess()
        {
            Console.Write("> ");
            var guess = Console.ReadLine().ToUpper();

            if (guess.Length > 1)
            {
                Program.round.GuessWord(guess);
            }
            else if (guess.Length == 1)
            {
                Program.round.GuessLetter(guess.ToString());
            }
        }
    }
}
