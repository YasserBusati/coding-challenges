using CodingChallenges.Maths.PalindromeNumber;

namespace tests.Maths;

public class PalindromeNumberTests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    [InlineData(0, true)]
    [InlineData(12321, true)]
    [InlineData(1221, true)]
    [InlineData(12345, false)]
    [InlineData(1000001, true)]
    [InlineData(1234321, true)]
    [InlineData(12344321, true)]
    public void TestIsPalindrome(int number, bool expected)
    {
        // Test Solution 1 (String conversion)
        // Act
        var result1 = PalindromeNumber.IsPalindromeStringConversion(number);

        // Assert
        Assert.Equal(expected, result1);

        // Test Solution 2 (Mathematical reversal)
        // Act
        var result2 = PalindromeNumber.IsPalindromeMathReversal(number);

        // Assert
        Assert.Equal(expected, result2);
    }
}