using System.Text;

namespace CodingChallenges.Maths.IntegerToRoman;

public class IntegerToRoman
{
    public static void Run()
    {
        int num = 1994;
        string result = IntToRoman(num);
        Console.WriteLine($"The Roman numeral for {num} is: {result}");
    }
    public static string IntToRoman(int num)
    {
        var romanMap = new (int value, string symbol)[] {
            (1000, "M"),
            (900,  "CM"),
            (500,  "D"),
            (400,  "CD"),
            (100,  "C"),
            (90,   "XC"),
            (50,   "L"),
            (40,   "XL"),
            (10,   "X"),
            (9,    "IX"),
            (5,    "V"),
            (4,    "IV"),
            (1,    "I")
        };

        var result = new StringBuilder();

        foreach (var (value, symbol) in romanMap)
        {
            while (num >= value)
            {
                result.Append(symbol);
                num -= value;
            }
        }

        return result.ToString();
    }
}
