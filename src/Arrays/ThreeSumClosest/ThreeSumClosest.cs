namespace CodingChallenges.Arrays.ThreeSumClosest;

public class ThreeSumClosest
{
    public static void Run()
    {
        int[] nums = [-1, 2, 1, -4];
        int target = 1;
        int result = FindThreeSumClosest(nums, target);
        Console.WriteLine($"The sum closest to {target} is {result}.");
    }

    public static int FindThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        int closestSum = nums[0] + nums[1] + nums[2];
        int n = nums.Length;

        for (int i = 0; i < n - 2; i++)
        {
            int left = i + 1;
            int right = n - 1;

            while (left < right)
            {
                int currentSum = nums[i] + nums[left] + nums[right];

                if (Math.Abs(currentSum - target) < Math.Abs(closestSum - target))
                {
                    closestSum = currentSum;
                }

                if (currentSum < target)
                {
                    left++;
                }
                else if (currentSum > target)
                {
                    right--;
                }
                else
                {
                    return currentSum; // Exact match found
                }
            }
        }

        return closestSum;
    }
}