using System;

namespace wof
{
    public static class WordBank
    {
        private static string[] wordBank = new[] { "Object Oriented Programming", "Satya Nadella", "Tom Cruise" };

        public static string GetWord()
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(0, wordBank.Length);
            return wordBank[rndNum];
        }
    }
}
