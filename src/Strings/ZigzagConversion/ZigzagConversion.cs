using System.Text;

namespace CodingChallenges.Strings;

public class ZigzagConversion
{
    public static void Run()
    {
        string s = "PAYPALISHIRING";
        int numRows = 3;
        string result = Convert(s, numRows);
        Console.WriteLine($"Zigzag conversion: {result}");
    }
    public static string Convert(string s, int numRows)
    {
        if (numRows == 1 || s.Length <= numRows)
            return s;

        var rows = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++)
            rows[i] = new StringBuilder();

        int currentRow = 0;
        bool goingDown = false;

        foreach (char c in s)
        {
            rows[currentRow].Append(c);

            if (currentRow == 0 || currentRow == numRows - 1)
                goingDown = !goingDown;

            currentRow += goingDown ? 1 : -1;
        }

        StringBuilder result = new();
        foreach (var row in rows)
            result.Append(row);

        return result.ToString();
    }
}