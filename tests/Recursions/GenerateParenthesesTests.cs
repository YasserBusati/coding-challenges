using CodingChallenges.Recursions.GenerateParentheses;

namespace tests.Recursions;

public class GenerateParenthesesTests
{
    [Fact]
    public void Test_N0()
    {
        var result = GenerateParentheses.GenerateParenthesis(0);
        Assert.Equal([""], result);
    }

    [Fact]
    public void Test_N1()
    {
        var result = GenerateParentheses.GenerateParenthesis(1);
        Assert.Equal(["()"], result);
    }

    [Fact]
    public void Test_N2()
    {
        var result = GenerateParentheses.GenerateParenthesis(2);
        var expected = new List<string> { "(())", "()()" };
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Test_N3()
    {
        var result = GenerateParentheses.GenerateParenthesis(3);
        var expected = new List<string>
        {
            "((()))",
            "(()())",
            "(())()",
            "()(())",
            "()()()"
        };
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Test_N4_Count()
    {
        var result = GenerateParentheses.GenerateParenthesis(4);
        Assert.Equal(14, result.Count);
    }

    [Fact]
    public void Test_AllCombinationsAreValid()
    {
        var result = GenerateParentheses.GenerateParenthesis(4);

        foreach (var combination in result)
        {
            Assert.True(IsValidParenthesis(combination));
        }
    }

    private static bool IsValidParenthesis(string s)
    {
        int balance = 0;
        foreach (char c in s)
        {
            if (c == '(') balance++;
            else balance--;

            if (balance < 0) return false;
        }
        return balance == 0;
    }

}