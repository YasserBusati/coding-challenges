namespace CodingChallenges.Strings.LongestSubstringWithoutRepeating;

public class LongestSubstringWithoutRepeating
{
    public static void Run()
    {
        string s = "abcabcbb";
        int resultBad = LengthOfLongestSubstringSlow(s);
        int resultGood = LengthOfLongestSubstringFast(s);
        Console.WriteLine($"Longest substring without repeating characters (bad): {resultBad}");
        Console.WriteLine($"Longest substring without repeating characters (good): {resultGood}");
    }

    public static int LengthOfLongestSubstringSlow(string s)
    {
        int maxLength = 0;
        for (int i = 0; i < s.Length; i++)
        {
            HashSet<char> charSet = [];
            for (int j = i; j < s.Length; j++)
            {
                if (charSet.Contains(s[j]))
                {
                    break;
                }
                charSet.Add(s[j]);
                maxLength = Math.Max(maxLength, j - i + 1);
            }
        }
        return maxLength;
    }
    public static int LengthOfLongestSubstringFast(string s)
    {
        HashSet<char> charSet = [];
        int left = 0, maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (charSet.Contains(s[right]))
            {
                charSet.Remove(s[left]);
                left++;
            }
            charSet.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }

}