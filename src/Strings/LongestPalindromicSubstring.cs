namespace CodingChallenges.Strings;
public class LongestPalindromicSubstring
{
    public static void Run()
    {
        string s = "babad";
        string result = LongestPalindrome(s);
        Console.WriteLine($"Longest palindromic substring: {result}");
    }
    public static string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return string.Empty;

        int start = 0, end = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int odd = ExpandAroundCenter(s, i, i);   // Odd length palindrome
            int even = ExpandAroundCenter(s, i, i + 1); // Even length palindrome
            int len = Math.Max(odd, even);

            if (len > end - start)
            {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }

        return s.Substring(start, end - start + 1);
    }
    private static int ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right - left - 1;
    }
}
