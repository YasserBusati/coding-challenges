using CodingChallenges.CodingInterviews;

namespace tests.CodingInterviews;

public class FindLongestWordInSentenceTests
{
    [Theory]
    [InlineData("The quick brown fox jumps over the lazy dog", "quick")]
    [InlineData("Hello, world!", "Hello")]
    [InlineData("C# is awesome!", "awesome")]
    [InlineData("Single", "Single")]
    [InlineData("Multiple    spaces   between", "Multiple")]
    [InlineData("Punctuation! test... works?", "Punctuation")]
    [InlineData("Hyphenated-word test", "Hyphenated-word")]
    [InlineData("123 numbers 4567", "numbers")]
    [InlineData("", "")]
    [InlineData("   ", "")]
    public void FindLongestWord_ReturnsCorrectResult(string input, string expected)
    {
        // Act
        var result = FindLongestWordInSentence.FindLongestWord(input);
        var resultWithLinq = FindLongestWordInSentence.FindLongestWordWithLinq(input);

        // Assert
        Assert.Equal(expected, result);
        Assert.Equal(expected, resultWithLinq);
    }

    [Fact]
    public void FindLongestWord_WhenMultipleLongestWords_ReturnsFirstOccurrence()
    {
        // Arrange
        var input = "first second third fourth";

        // Act
        var result = FindLongestWordInSentence.FindLongestWord(input);

        // Assert
        Assert.Equal("second", result);
    }

    [Fact]
    public void FindLongestWord_WithApostrophes_HandlesCorrectly()
    {
        // Arrange
        var input = "Don't stop believing";

        // Act
        var result = FindLongestWordInSentence.FindLongestWord(input);

        // Assert
        Assert.Equal("believing", result);
    }
}