using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace wof
{
    public class Word
    {
        private string word;

        public Word()
        {
            word = WordBank.GetWord();
        }

        public bool DisplayWord()
        {
            string display = "\n\n";
            char[] guesses = Round.GetGuesses();
            int correct = 0;

            for (var i=0; i<word.Length; i++)
            {
                if (guesses.Contains(Char.ToUpper(word[i])))
                {
                    display += $" _{word[i]}_ ";
                    correct += 1;
                }
                else
                {
                    if (word[i] != ' ')
                    {
                        display += " ___ ";
                    }
                    else
                    {
                        display += "   ";
                        correct += 1;
                    }
                }
            }

            display += "\n\n";

            Console.WriteLine(display);

            return correct == word.Length;
        }

        public void PrintWord()
        {
            Console.WriteLine($"The secret word is: {word}.");
        }
    }
}
