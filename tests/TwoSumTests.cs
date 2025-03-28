

using CodingChallenges.Arrays;

namespace tests;

public class TwoSumTests
{
    [Fact]
    public void Test_TwoSum_ValidInput()
    {
        int[] nums = [2, 7, 11, 15];
        int target = 9;
        int[] expected = [0, 1];

        int[] result = TwoSum.FindTwoSum(nums, target);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_TwoSum_NoSolution()
    {
        int[] nums = [1, 2, 3, 4];
        int target = 10;

        int[] result = TwoSum.FindTwoSum(nums, target);

        Assert.Empty(result);
    }
}
