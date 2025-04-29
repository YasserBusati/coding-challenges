namespace CodingChallenges.Maths.PalindromeNumber;

public class PalindromeNumber
{
    public static void Run()
    {
        int number = 1234;
        bool result1 = IsPalindromeStringConversion(number);
        bool result2 = IsPalindromeMathReversal(number);
        Console.WriteLine($"Is Palindrome Value: {result1}");
        Console.WriteLine($"Is Palindrome Value: {result2}");
    }
    public static bool IsPalindromeStringConversion(int x)
    {
        // Negative numbers can't be palindromes
        if (x < 0) return false;

        string numStr = x.ToString();
        int left = 0;
        int right = numStr.Length - 1;

        while (left < right)
        {
            if (numStr[left] != numStr[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    public static bool IsPalindromeMathReversal(int x)
    {
        // Special cases:
        // When x < 0, it's not a palindrome(nagative)
        // If the last digit is 0, the first digit must also be 0 (only 0 satisfies this)
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int reversedNumber = 0;
        while (x > reversedNumber)
        {
            reversedNumber = reversedNumber * 10 + x % 10;
            x /= 10;
        }

        // When the length is odd, we can get rid of the middle digit
        return x == reversedNumber || x == reversedNumber / 10;
    }
}