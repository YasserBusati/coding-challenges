namespace CodingChallenges.Stacks.ValidParentheses;

public class ValidParentheses
{
    public static bool IsValid(string s)
    {
        Stack<char> stack = new();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) return false;

                char top = stack.Pop();
                if (!IsMatchingPair(top, c))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    private static bool IsMatchingPair(char opening, char closing)
    {
        return (opening == '(' && closing == ')') ||
               (opening == '[' && closing == ']') ||
               (opening == '{' && closing == '}');
    }
}