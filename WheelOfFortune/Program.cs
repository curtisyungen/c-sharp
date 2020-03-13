using System;

namespace wof
{
    public static class Program
    {
        public static bool playing = false;
        public static Round round;

        static void Main()
        {
            NewGame();
            PlayGame();
            EndGame();
        }

        /// <summary>
        /// Displays welcome message and initiates a new round.
        /// </summary>
        public static void NewGame()
        {
            Console.WriteLine("Welcome to Wheel of Fortune!");

            round = new Round();
            playing = true;
        }

        /// <summary>
        /// Handles gameplay, allowing user to guess letters until puzzle is solved.
        /// </summary>
        public static void PlayGame()
        {
            while (playing)
            {
                Guess guess = new Guess();
            }
        }

        public static void EndGame()
        {
            Console.WriteLine("You win!");
            Console.WriteLine("Play again?");
            var playAgain = Console.ReadKey();

            if (playAgain.KeyChar == 'Y' || playAgain.KeyChar == 'y')
            {
               Main();
            }
        }
    }
}
