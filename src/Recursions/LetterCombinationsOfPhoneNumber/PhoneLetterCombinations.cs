namespace CodingChallenges.Recursions.LetterCombinationsOfPhoneNumber;

public class PhoneLetterCombinations
{
    public static void Run()
    {
        var digits = "23";
        var result = LetterCombinations(digits);
        Console.WriteLine(string.Join(", ", result));
    }
    public static IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
            return [];

        var digitToLetters = new Dictionary<char, string>
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

        var result = new List<string>();
        GenerateCombinations(digits, 0, "", digitToLetters, result);
        return result;
    }

    private static void GenerateCombinations(string digits, int index, string currentCombination,
        Dictionary<char, string> digitToLetters, List<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(currentCombination);
            return;
        }

        char digit = digits[index];
        if (digitToLetters.TryGetValue(digit, out string? value))
        {
            foreach (char letter in value)
            {
                GenerateCombinations(digits, index + 1, currentCombination + letter, digitToLetters, result);
            }
        }
    }
}