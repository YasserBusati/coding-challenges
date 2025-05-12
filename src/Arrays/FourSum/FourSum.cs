namespace CodingChallenges.Arrays.FourSum;

public class FourSum
{
    public static void Run()
    {
        int[] nums = [1, 0, -1, 0, -2, 2];
        int target = 0;
        IList<IList<int>> result = FindFourSum(nums, target);
        foreach (var quadruplet in result)
        {
            Console.WriteLine($"[{string.Join(", ", quadruplet)}]");
        }
    }

    public static IList<IList<int>> FindFourSum(int[] nums, int target)
    {
        List<IList<int>> result = [];
        if (nums == null || nums.Length < 4)
        {
            return result;
        }

        Array.Sort(nums);
        int n = nums.Length;

        for (int i = 0; i < n - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue; // Skip duplicates

            // Early termination: if smallest possible sum exceeds target
            if ((long)nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target)
            {
                break;
            }

            // Early termination: if largest possible sum is less than target
            if ((long)nums[i] + nums[n - 3] + nums[n - 2] + nums[n - 1] < target)
            {
                continue;
            }

            for (int j = i + 1; j < n - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue; // Skip duplicates

                int left = j + 1;
                int right = n - 1;

                while (left < right)
                {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                    if (sum == target)
                    {
                        result.Add([nums[i], nums[j], nums[left], nums[right]]);

                        while (left < right && nums[left] == nums[left + 1]) left++; // Skip duplicates
                        while (left < right && nums[right] == nums[right - 1]) right--; // Skip duplicates
                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}