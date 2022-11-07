using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name:");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\dell\Documents\GitHub\TTA-Basic-C-Sharp-Projects\Basic_C#_Programs\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path); //Read All Lines in path variable established above

            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores:    \n");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;

            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length +  " student scores. \tAverage score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();

        }
    }
}
