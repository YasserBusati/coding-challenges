using CodingChallenges.Maths.RomanToInteger;

namespace tests.Maths;

public class RomanToIntegerTests
{

    [Theory]
    [InlineData("I", 1)]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    [InlineData("L", 50)]
    [InlineData("C", 100)]
    [InlineData("D", 500)]
    [InlineData("M", 1000)]
    public void Converts_Single_Symbols_Correctly(string roman, int expected)
    {
        var result = RomanToInteger.RomanToInt(roman);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("II", 2)]
    [InlineData("VI", 6)]
    [InlineData("XV", 15)]
    [InlineData("XX", 20)]
    [InlineData("CL", 150)]
    public void Handles_Additive_Notation_Correctly(string roman, int expected)
    {
        var result = RomanToInteger.RomanToInt(roman);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("XL", 40)]
    [InlineData("XC", 90)]
    [InlineData("CD", 400)]
    [InlineData("CM", 900)]
    public void Handles_Subtractive_Notation_Correctly(string roman, int expected)
    {
        var result = RomanToInteger.RomanToInt(roman);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("III", 3)]
    [InlineData("XXVII", 27)]
    [InlineData("XLVIII", 48)]
    [InlineData("XCIX", 99)]
    [InlineData("CCXLVI", 246)]
    public void Handles_Combination_Numbers_Correctly(string roman, int expected)
    {
        var result = RomanToInteger.RomanToInt(roman);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("MCMXCIV", 1994)]
    [InlineData("MMXIX", 2019)]
    [InlineData("MMXXIII", 2023)]
    [InlineData("MMMCMXCIX", 3999)]
    public void Handles_Complex_Numbers_Correctly(string roman, int expected)
    {
        var result = RomanToInteger.RomanToInt(roman);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("I", 1)]
    [InlineData("IV", 4)]
    [InlineData("XL", 40)]
    [InlineData("CM", 900)]
    public void Handles_Lowercase_Input(string roman, int expected)
    {
        var result = RomanToInteger.RomanToInt(roman);
        Assert.Equal(expected, result);
    }



}