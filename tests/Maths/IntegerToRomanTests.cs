using CodingChallenges.Maths.IntegerToRoman;
namespace tests.Maths;
public class IntegerToRomanTests
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(9, "IX")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    [InlineData(2023, "MMXXIII")]
    [InlineData(3999, "MMMCMXCIX")]
    public void Convert_ValidNumbers_ReturnsCorrectRoman(int num, string expected)
    {

        var result = IntegerToRoman.IntToRoman(num);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Convert_MinValue_ReturnsI()
    {

        var result = IntegerToRoman.IntToRoman(1);
        Assert.Equal("I", result);
    }

    [Fact]
    public void Convert_MaxValue_ReturnsMMMCMXCIX()
    {

        var result = IntegerToRoman.IntToRoman(3999);
        Assert.Equal("MMMCMXCIX", result);
    }

    [Theory]
    [InlineData(40, "XL")]
    [InlineData(90, "XC")]
    [InlineData(400, "CD")]
    [InlineData(900, "CM")]
    public void Convert_SubtractiveNotation_ReturnsCorrectRoman(int num, string expected)
    {

        var result = IntegerToRoman.IntToRoman(num);
        Assert.Equal(expected, result);
    }
}