namespace CodingChallenges.Recursions.GenerateParentheses;

public class GenerateParentheses
{
    public static void Run()
    {
        var result = GenerateParenthesis(4);
        Console.WriteLine($"this is Result Of Posible Combination Of Parentheses: {result}");
    }
    public static IList<string> GenerateParenthesis(int n)
    {
        List<string> result = [];
        Backtrack(result, "", 0, 0, n);
        return result;
    }

    private static void Backtrack(List<string> result, string current, int open, int close, int max)
    {
        if (current.Length == max * 2)
        {
            result.Add(current);
            return;
        }

        if (open < max)
        {
            Backtrack(result, current + "(", open + 1, close, max);
        }
        if (close < open)
        {
            Backtrack(result, current + ")", open, close + 1, max);
        }
    }
}