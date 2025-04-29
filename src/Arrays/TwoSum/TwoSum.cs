namespace CodingChallenges.Arrays.TwoSum;
public class TwoSum
{
    public static void Run()
    {
        int[] nums = [2, 7, 11, 15];
        int target = 9;
        var result = FindTwoSum(nums, target);
        Console.WriteLine($"Indices: {result[0]}, {result[1]}");
    }

    public static int[] FindTwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        return []; ;
    }
}
