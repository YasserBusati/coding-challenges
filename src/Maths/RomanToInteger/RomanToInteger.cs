namespace CodingChallenges.Maths.RomanToInteger;

public class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        var romanValues = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int currentValue = romanValues[s[i]];


            // If this is not the last symbol and the next symbol is larger,
            // subtract this value (e.g., IV = 5 - 1)
            if (currentValue < prevValue)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
            }

            prevValue = currentValue;
        }

        return total;
    }
}