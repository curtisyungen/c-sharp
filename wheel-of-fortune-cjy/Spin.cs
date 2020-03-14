using System;
using System.Collections.Generic;
using System.Text;

namespace wheel_of_fortune_cjy
{
    public class Spin
    {
        private static int[] possPoints = new int[] { 20, 40, 60, 80, 100 };
        private static int points;

        public Spin()
        {
            Console.WriteLine("Spinning...");
            SpinWheel();
        }

        public void SpinWheel()
        {
            Random rnd = new Random();
            int randNum = rnd.Next(0, possPoints.Length);
            points = possPoints[randNum];
            Console.WriteLine($"Wheel landed on {points}.\n");
        }

        public int GetPoints()
        {
            return points;
        }
    }
}
