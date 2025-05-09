using CodingChallenges.Recursions.LetterCombinationsOfPhoneNumber;

namespace tests.Recursions;

public class PhoneLetterCombinationsTests
{

    [Fact]
    public void TestEmptyInput()
    {
        var result = PhoneLetterCombinations.LetterCombinations("");
        Assert.Empty(result);
    }

    [Fact]
    public void TestSingleDigit()
    {
        var result = PhoneLetterCombinations.LetterCombinations("2");
        var expected = new List<string> { "a", "b", "c" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestTwoDigits()
    {
        var result = PhoneLetterCombinations.LetterCombinations("23");
        var expected = new List<string> {
            "ad", "ae", "af",
            "bd", "be", "bf",
            "cd", "ce", "cf"
        };
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void TestDigitsWithFourLetters()
    {
        var result = PhoneLetterCombinations.LetterCombinations("79");
        var expected = new List<string> {
            "pw", "px", "py", "pz",
            "qw", "qx", "qy", "qz",
            "rw", "rx", "ry", "rz",
            "sw", "sx", "sy", "sz"
        };
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void TestAllDigits()
    {
        var result = PhoneLetterCombinations.LetterCombinations("234");

        Assert.Equal(27, result.Count);
        Assert.Contains("adg", result);
        Assert.Contains("cfi", result);
        Assert.DoesNotContain("xyz", result);
    }

    [Fact]
    public void TestDigitsWithSameLetters()
    {
        var result = PhoneLetterCombinations.LetterCombinations("22");
        var expected = new List<string> {
            "aa", "ab", "ac",
            "ba", "bb", "bc",
            "ca", "cb", "cc"
        };
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void TestLargeInput()
    {
        var result = PhoneLetterCombinations.LetterCombinations("23456789");
        Assert.Equal(11664, result.Count);

        Assert.StartsWith("adgjmptw", result.First());
        Assert.EndsWith("cfilosvz", result.Last());
        Assert.All(result, combo => Assert.Equal(8, combo.Length));
    }



}