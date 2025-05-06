using CodingChallenges.Arrays.ThreeSum;

namespace tests.Arrays;
public class ThreeSumTests
{


    [Fact]
    public void BasicCase_ReturnsCorrectTriplets()
    {
        int[] nums = [-1, 0, 1, 2, -1, -4];
        var expected = new List<IList<int>> {
            new List<int> { -1, -1, 2 },
            new List<int> { -1, 0, 1 }
        };

        var result = ThreeSum.FindThreeSum(nums);

        Assert.Equal(expected.Count, result.Count);
        Assert.All(result, triplet => Assert.Contains(triplet, expected));
    }

    [Fact]
    public void NoValidTriplets_ReturnsEmptyList()
    {
        int[] nums = [1, 2, -2, -1];
        var expected = new List<IList<int>>();

        var result = ThreeSum.FindThreeSum(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void AllZeros_ReturnsSingleTriplet()
    {
        int[] nums = [0, 0, 0, 0];
        var expected = new List<IList<int>> {
            new List<int> { 0, 0, 0 }
        };

        var result = ThreeSum.FindThreeSum(nums);

        Assert.Equal(expected.Count, result.Count);
        Assert.Equal(expected[0], result[0]);
    }

    [Fact]
    public void WithDuplicates_ReturnsUniqueTriplets()
    {
        int[] nums = [-2, 0, 1, 1, 2];
        var expected = new List<IList<int>> {
            new List<int> { -2, 0, 2 },
            new List<int> { -2, 1, 1 }
        };

        var result = ThreeSum.FindThreeSum(nums);

        Assert.Equal(expected.Count, result.Count);
        Assert.All(result, triplet => Assert.Contains(triplet, expected));
    }

    [Fact]
    public void SmallArray_ReturnsEmptyList()
    {
        int[] nums1 = [];
        int[] nums2 = [1];
        int[] nums3 = [1, 2];

        Assert.Empty(ThreeSum.FindThreeSum(nums1));
        Assert.Empty(ThreeSum.FindThreeSum(nums2));
        Assert.Empty(ThreeSum.FindThreeSum(nums3));
    }

}