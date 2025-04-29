namespace CodingChallenges.Strings.StringToInteger_atoi_;

public class StringToInteger
{

    public static void Run()
    {
        string s = "-2147483647";
        int result = MyAtoi(s);
        Console.WriteLine($"Number: {result}");
    }
    public static int MyAtoi(string s)
    {
        int index = 0;
        int sign = 1;
        int result = 0;

        // 1. Skip leading whitespace
        while (index < s.Length && s[index] == ' ')
        {
            index++;
        }

        // 2. Handle sign
        if (index < s.Length && (s[index] == '+' || s[index] == '-'))
        {
            sign = s[index] == '-' ? -1 : 1;
            index++;
        }

        // 3. Process digits
        while (index < s.Length && char.IsDigit(s[index]))
        {
            int digit = s[index] - '0';

            // Check for overflow
            if (result > int.MaxValue / 10 ||
                (result == int.MaxValue / 10 && digit > int.MaxValue % 10))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            index++;
        }

        return result * sign;
    }
}