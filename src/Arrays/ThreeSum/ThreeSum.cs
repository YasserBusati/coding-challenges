namespace CodingChallenges.Arrays.ThreeSum;

public class ThreeSum
{
    public static void Run()
    {
        int[] nums = [-1, 0, 1, 2, -1, -4];
        List<List<int>> result = FindThreeSum(nums);
        foreach (var triplet in result)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }
    }
    public static List<List<int>> FindThreeSum(int[] nums)
    {
        List<List<int>> result = [];
        Array.Sort(nums);
        int n = nums.Length;

        for (int i = 0; i < n - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue; // Skip duplicates

            int left = i + 1;
            int right = n - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add([nums[i], nums[left], nums[right]]);
                    while (left < right && nums[left] == nums[left + 1]) left++; // Skip duplicates
                    while (left < right && nums[right] == nums[right - 1]) right--; // Skip duplicates
                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}