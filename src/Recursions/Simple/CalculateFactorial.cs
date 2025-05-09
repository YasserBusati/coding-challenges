namespace CodingChallenges.Recursions.Simple;

public class CalculateFactorial
{
    public static void Run()
    {
        int number = 5;
        int result = Factorial(number);
        Console.WriteLine($"Factorial of {number} is {result}");
    }

    public static int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Input must be a non-negative integer.");
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }
}