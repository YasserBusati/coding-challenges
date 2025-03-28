namespace CodingChallenges;

using System;

class Program
{
    static void Main(string[] args)
    {
        string problemName;

        if (args.Length > 0)
        {
            problemName = args[0];
        }
        else
        {
            Console.WriteLine("Enter the problem to run (e.g., TwoSum): ");
            problemName = Console.ReadLine();
        }

        try
        {
            ProblemRunner.Run(problemName);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

