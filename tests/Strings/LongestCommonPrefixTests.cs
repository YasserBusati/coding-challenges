namespace tests.Strings;
using System.Diagnostics;
using CodingChallenges.Strings.LongestCommonPrefix;

public class LongestCommonPrefixTests
{
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    [InlineData(new[] { "interspecies", "interstellar", "interstate" }, "inters")]
    [InlineData(new[] { "apple", "apple", "apple" }, "apple")]
    [InlineData(new[] { "" }, "")]
    [InlineData(new string[] { }, "")]
    public void TestCommonPrefix(string[] input, string expected)
    {
        Assert.Equal(expected, LongestCommonPrefix.FindLongestCommonPrefixSlow(input));
        Assert.Equal(expected, LongestCommonPrefix.FindLongestCommonPrefixFast(input));
    }


}