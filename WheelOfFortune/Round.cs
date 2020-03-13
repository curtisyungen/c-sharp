using System;

namespace wof
{
    public class Round
    {
        private Word word;
        private static char[] guesses;
        private int numGuesses;

        public Round()
        {
            word = new Word();
            guesses = new char[26];
            numGuesses = 0;

            Console.WriteLine("\nHere is your secret word: \n");
            word.DisplayWord();
        }

        public void GuessLetter(ConsoleKey letter)
        {
            guesses[numGuesses] = (char)letter;
            numGuesses += 1;

            bool solved = word.DisplayWord();

            if (solved)
            {
                Program.playing = false;
            }
        }

        public static char[] GetGuesses()
        {
            return guesses;
        }

        public static void ShowGuesses()
        {
            Console.WriteLine("\nGuesses:  ");
            for (var i=0; i<guesses.Length; i++)
            {
                Console.Write(guesses[i] + " ");
            }
        }
    }
}