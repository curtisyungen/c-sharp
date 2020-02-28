using System;
using System.Text;

namespace first_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = "Dallas";
            var temperature = 103.4f;
            var currentDt = DateTime.Now;
            string.Format("Welcome to {0}. The time is {1}. The temperature is {2}.", city, currentDt, temperature);
            
        }
    }
}
