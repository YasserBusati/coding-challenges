using CodingChallenges.Arrays.ThreeSumClosest;

namespace tests.Arrays;

public class ThreeSumClosestTests
{

    [Fact]
    public void TestExactMatchExists()
    {
        int[] nums = [-1, 2, 1, -4];
        int target = 1;
        int expected = 2; // -1 + 2 + 1 = 2
        int result = ThreeSumClosest.FindThreeSumClosest(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestNoExactMatch()
    {
        int[] nums = [1, 1, 1, 0];
        int target = 100;
        int expected = 3; // 1 + 1 + 1 = 3
        int result = ThreeSumClosest.FindThreeSumClosest(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestNegativeNumbers()
    {
        int[] nums = [-3, -2, -5, 3, -4];
        int target = -1;
        int expected = -2; // -2 + 3 + (-3) = -2
        int result = ThreeSumClosest.FindThreeSumClosest(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestLargeArray()
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int target = 18;
        int expected = 18; // 5 + 6 + 7 = 18 (exact match)
        int result = ThreeSumClosest.FindThreeSumClosest(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestAllSameElements()
    {
        int[] nums = [5, 5, 5, 5, 5];
        int target = 15;
        int expected = 15; // 5 + 5 + 5 = 15 (exact match)
        int result = ThreeSumClosest.FindThreeSumClosest(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestMinimumSizeArray()
    {
        int[] nums = [1, 2, 3];
        int target = 6;
        int expected = 6; // Only possible triplet
        int result = ThreeSumClosest.FindThreeSumClosest(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestTwoEquallyCloseSolutions()
    {
        int[] nums = [1, 2, 3, 4, 5];
        int target = 8;
        int expected = 8;
        int result = ThreeSumClosest.FindThreeSumClosest(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestLargeNumbers()
    {
        int[] nums = [1000, 2000, 3000, 4000];
        int target = 5001;
        int expected = 6000; // 2000 + 3000 + 1000
        int result = ThreeSumClosest.FindThreeSumClosest(nums, target);
        Assert.Equal(expected, result);
    }
}
