using CodingChallenges.Strings.StringToInteger_atoi_;

namespace tests.Strings;

public class StringToIntegerTests
{
    [Theory]
    [InlineData("42", 42)]
    [InlineData("   -42", -42)]
    [InlineData("4193 with words", 4193)]
    [InlineData("words and 987", 0)]
    [InlineData("", 0)]
    [InlineData("  0000000000012345678", 12345678)]
    [InlineData("2147483647", int.MaxValue)]
    [InlineData("2147483648", int.MaxValue)]
    [InlineData("-2147483648", int.MinValue)]
    [InlineData("-2147483649", int.MinValue)]
    [InlineData("   +1", 1)]
    [InlineData("   +-12", 0)]
    [InlineData("   -+12", 0)]
    [InlineData("   - 12", 0)]
    [InlineData("   + 12", 0)]
    [InlineData("  000000000000000012", 12)]
    [InlineData("  -000000000000000012", -12)]
    [InlineData("  000000000000000000", 0)]
    [InlineData("  -000000000000000000", 0)]
    [InlineData("  0000000000000000012", 12)]
    [InlineData("  0000000000000000012abc", 12)]
    [InlineData("  -0000000000000000012abc", -12)]
    [InlineData("  0000000000000000000abc", 0)]
    [InlineData("  -0000000000000000000abc", 0)]
    [InlineData("  0000000000000000001abc", 1)]
    [InlineData("  -0000000000000000001abc", -1)]
    [InlineData("  0000000000000000000", 0)]
    [InlineData("  -0000000000000000000", 0)]
    [InlineData("  0000000000000000001", 1)]
    [InlineData("  -0000000000000000001", -1)]
    public void MyAtoi_ReturnsCorrectResult(string input, int expected)
    {

        // Act
        var result = StringToInteger.MyAtoi(input);

        // Assert
        Assert.Equal(expected, result);
    }
}