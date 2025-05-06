namespace CodingChallenges.Strings.LongestCommonPrefix;

public class LongestCommonPrefix
{
    public static void Run()
    {
        string[] input = ["flower", "flow", "flight"];
        string result1 = FindLongestCommonPrefixSlow(input);
        string result2 = FindLongestCommonPrefixFast(input);
        Console.WriteLine($"Longest Common Prefix (Slow): {result1}");
        Console.WriteLine($"Longest Common Prefix (Fast): {result2}");
    }
    public static string FindLongestCommonPrefixSlow(string[] strs)
    {
        if (strs.Length == 0) return string.Empty;


        string prefix = strs[0];


        for (int i = 1; i < strs.Length; i++)
        {

            while (!strs[i].StartsWith(prefix))
            {

                prefix = prefix[..^1];
                if (prefix.Length == 0) return string.Empty;
            }
        }

        return prefix;
    }

    public static string FindLongestCommonPrefixFast(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        Array.Sort(strs);

        string first = strs[0];
        string last = strs[strs.Length - 1];

        int minLength = Math.Min(first.Length, last.Length);
        int i = 0;

        while (i < minLength && first[i] == last[i])
        {
            i++;
        }

        return first[..i];
    }
}