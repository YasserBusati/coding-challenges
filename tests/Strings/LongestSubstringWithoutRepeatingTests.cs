using CodingChallenges.Strings.LongestSubstringWithoutRepeating;

namespace tests.Strings;


public class LongestSubstringWithoutRepeatingTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData(" ", 1)]
    [InlineData("dvdf", 3)]
    [InlineData("anviaj", 5)]
    public void LengthOfLongestSubstringFast_ShouldReturnExpectedResult(string input, int expected)
    {
        int result = LongestSubstringWithoutRepeating.LengthOfLongestSubstringFast(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData(" ", 1)]
    [InlineData("dvdf", 3)]
    [InlineData("anviaj", 5)]
    public void LengthOfLongestSubstringSlow_ShouldReturnExpectedResult(string input, int expected)
    {
        int result = LongestSubstringWithoutRepeating.LengthOfLongestSubstringSlow(input);
        Assert.Equal(expected, result);
    }
}

