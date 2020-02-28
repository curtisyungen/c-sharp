using System;
using System.Collections.Generic;
using System.IO;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> Words;
        static void Main(string[] args)
        {
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProblem();
            ReadTextFile();
            Console.ReadLine();
        }

        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i=10; i>0; i--)
            {
                income = (income / i);
            }

            return income;
        }

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\Users\curtisyungen\desktop\c-sharp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the file.");
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the directory.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unknown error occurred " + ex.Message);
            }
            finally
            {
                Console.WriteLine("The finally runs all the time.");
            }
        }
    }
}
