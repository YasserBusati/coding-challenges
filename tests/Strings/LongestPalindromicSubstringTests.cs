

using CodingChallenges.Strings.LongestPalindromicSubstring;

namespace tests.Strings;

public class LongestPalindromicSubstringTests
{

    [Theory]
    [InlineData("cbbd", "bb")]
    [InlineData("a", "a")]
    [InlineData("racecar", "racecar")]
    [InlineData("abacdfgdcaba", "aba")]
    [InlineData("", "")]
    public void TestLongestPalindrome(string input, string expectedStart)
    {
        string result = LongestPalindromicSubstring.LongestPalindrome(input);
        Assert.Contains(expectedStart, result);
    }
}
