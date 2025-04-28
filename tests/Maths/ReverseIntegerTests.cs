using CodingChallenges.Maths;

namespace tests.Maths;

public class ReverseIntegerTests
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(0, 0)]
    [InlineData(1534236469, 0)]
    [InlineData(-1563847412, 0)]
    public void Reverse_ShouldReturnExpectedResult(int input, int expected)
    {

        // Act
        var result = ReverseInteger.Reverse(input);

        // Assert
        Assert.Equal(expected, result);
    }
}