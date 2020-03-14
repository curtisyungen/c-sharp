using System;
using System.Linq;
using wheel_of_fortune_cjy;

namespace wof
{
    public class Round
    {
        private static Word word;
        private static string[] guesses;
        private static string wordGuess = null;
        private int numGuesses;
        public int playerTurn = 0;

        public Round()
        {
            word = new Word();
            guesses = new string[26];
            numGuesses = 0;

            Console.WriteLine("\nHere is your secret word: ");
            word.DisplayWord();
        }

        public void GuessLetter(string letter)
        {
            CheckLetterGuess(letter) ;
            guesses[numGuesses] = letter;
            numGuesses += 1;
            CheckIfSolved();
        }

        public void GuessWord(string guess)
        {
            wordGuess = guess.ToUpper();
            CheckIfSolved();
        }

        public void CheckLetterGuess(string letter)
        {
            bool repeatGuess = Array.Exists(guesses, e => e == letter);
            if (!repeatGuess)
            {
                int count = word.ToString().Count(ch => ch.ToString().IndexOf(letter) > -1);

                if (count > 0)
                {
                    Program.scores[playerTurn] += Program.spin.GetPoints() * count;

                    Console.WriteLine($"Correct! There are {count} {letter}s. Spin again.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Next player.");
                    Console.ReadLine();
                    playerTurn += 1;
                    if (playerTurn > Program.numPlayers - 1)
                    {
                        playerTurn = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Letter has already been guessed. Try again.");
                Console.ReadLine();
            }
        }

        public void CheckIfSolved()
        {
            bool solved = wordGuess == word.ToString() || word.DisplayWord();
            if (solved)
            {
                Program.playing = false;
                SolvePuzzle();
            }
        }

        public static string[] GetGuesses()
        {
            return guesses;
        }

        public static void ShowGuesses()
        {
            Console.WriteLine("\nGuesses:  ");
            for (var i = 0; i < guesses.Length; i++)
            {
                Console.Write(guesses[i] + " ");
            }
        }

        public static void SolvePuzzle()
        {
            Console.WriteLine($"\nThe secret word was: {word}.\n");

            string winner;
            if (wordGuess == word.ToString())
            {
                winner = Program.players[Program.round.playerTurn];
            }
            else
            {
                int maxVal = Program.scores.Max();
                winner = Program.players[Program.scores.ToList().IndexOf(maxVal)];
            }

            Console.WriteLine("Final Scores: \n");
            for (var i=0; i<Program.scores.Length; i++)
            {
                Console.WriteLine($"{Program.players[i]}: {Program.scores[i]}");
            }

            Console.WriteLine($"\nThe winner was {winner}.");
        }
    }
}