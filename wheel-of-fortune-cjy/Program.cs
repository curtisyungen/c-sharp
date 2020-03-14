using System;
using wheel_of_fortune_cjy;

namespace wof
{
    public static class Program
    {
        public static bool playing = false;
        public static Round round;
        public static int numPlayers;
        public static string[] players;
        public static int[] scores;
        public static Spin spin;

        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Wheel of Fortune!");
            Console.WriteLine();

            GetNumberOfPlayers();
            GetPlayerNames();
            NewGame();
            PlayGame();
            EndGame();
        }

        public static void GetNumberOfPlayers()
        {
            bool validInput = false;
            while (!validInput) {
                Console.Write("\nEnter number of players (1-3): ");
                string strNumPlayers = Console.ReadLine();
                bool convertToNum = int.TryParse(strNumPlayers, out int numUsersPre);
                if (convertToNum)
                {
                    if (numUsersPre >= 1 && numUsersPre <= 3)
                    {
                        numPlayers = numUsersPre;
                        players = new string[numPlayers];
                        scores = new int[numPlayers];
                        validInput = true;
                        
                    }
                    else
                    {
                        Console.WriteLine("Enter a number between 1 and 3.");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a number between 1 and 3.");
                }
            }
        }

        public static void GetPlayerNames()
        {
            for (var i=0; i<numPlayers; i++)
            {
                Console.Write($"Enter name of player {i + 1}: ");
                players[i] = Console.ReadLine();
            }
        }

        /// <summary>
        /// Displays welcome message and initiates a new round.
        /// </summary>
        public static void NewGame()
        {
            Console.WriteLine("Let the game begin!");

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
               spin = new Spin();
               new Guess();
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
