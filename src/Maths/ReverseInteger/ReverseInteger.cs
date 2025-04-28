namespace CodingChallenges.Maths.ReverseInteger;

public class ReverseInteger
{
    public static void Run()
    {
        int number = 1234;
        int result = Reverse(number);
        Console.WriteLine($"Reverse Value: {result}");
    }
    public static int Reverse(int x)
    {
        int result = 0;

        while (x != 0)
        {
            int digit = x % 10;
            x /= 10;

            // Check for overflow/underflow before actually updating result
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                return 0;
            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8))
                return 0;

            result = result * 10 + digit;
        }

        return result;
    }
}