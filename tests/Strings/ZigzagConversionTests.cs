using CodingChallenges.Strings.ZigzagConversion;

namespace tests.Strings;

public class ZigzagConversionTests
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    [InlineData("AB", 1, "AB")]
    [InlineData("ABC", 2, "ACB")]
    public void Convert_ShouldReturnZigzagPattern(string input, int numRows, string expected)
    {
        // Act
        var result = ZigzagConversion.Convert(input, numRows);

        // Assert
        Assert.Equal(expected, result);
    }
}