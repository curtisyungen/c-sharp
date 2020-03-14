using System;

namespace wof
{
    public class Word
    {
        private string word;

        public Word()
        {
            word = WordBank.GetWord().ToUpper();
        }

        public override string ToString()
        {
            return word;
        }

        public bool DisplayWord()
        {
            string display = "\n";
            string[] guesses = Round.GetGuesses();
            int correct = 0;

            for (var i = 0; i < word.Length; i++)
            {
                if (Array.Exists(guesses, e => e == word[i].ToString()))
                {
                    display += $" {word[i]} ";
                    correct += 1;
                }
                else
                {
                    if (word[i] != ' ')
                    {
                        display += "_ ";
                    }
                    else
                    {
                        display += "   ";
                        correct += 1;
                    }
                }
            }

            display += "\n";

            Console.Clear();
            Console.WriteLine(display);

            return correct == word.Length;
        }
    }
}
