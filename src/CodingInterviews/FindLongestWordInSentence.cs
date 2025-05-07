namespace CodingChallenges.CodingInterviews;

public class FindLongestWordInSentence
{
    public static void Run()
    {
        string sentence = "The quick brown fox jumps over the lazy dog.";
        string longestWord = FindLongestWord(sentence);
        Console.WriteLine($"Longest word: {longestWord}");

        string longestWordWithLink = FindLongestWordWithLinq(sentence);
        Console.WriteLine($"Longest word with Linq: {longestWordWithLink}");
    }
    public static string FindLongestWord(string sentence)
    {
        if (string.IsNullOrEmpty(sentence))
            return string.Empty;

        char[] separators = [' ', '.', ',', '!', '?', ';', ':', '\t', '\n'];

        string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
            return string.Empty;


        string longestWord = words[0];

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        return longestWord;
    }

    public static string FindLongestWordWithLinq(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
        {
            return string.Empty;
        }

        char[] separators = [' ', '.', ',', '!', '?', ';', ':', '\t', '\n'];
        string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
        {
            return string.Empty;
        }


        string longestWord = words.OrderByDescending(w => w.Length).First();

        return longestWord;
    }
}