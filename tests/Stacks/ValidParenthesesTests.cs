using CodingChallenges.Stacks.ValidParentheses;

namespace tests.Stacks;

public class ValidParenthesesTests
{

    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    [InlineData("", true)]
    [InlineData("(", false)]
    [InlineData("]", false)]
    [InlineData("((()))", true)]
    [InlineData("{[()]}", true)]
    [InlineData("{[(])}", false)]
    public void IsValid_TestCases(string input, bool expected)
    {
        var result = ValidParentheses.IsValid(input);
        Assert.Equal(expected, result);
    }
}