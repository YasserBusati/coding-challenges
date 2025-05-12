
using CodingChallenges.Arrays.FourSum;

namespace tests.Arrays;

public class FourSumTests
{


    private static bool AreQuadrupletsEqual(IList<IList<int>> actual, IList<IList<int>> expected)
    {
        if (actual.Count != expected.Count) return false;

        // Convert each quadruplet to a sorted list for comparison
        var actualSorted = actual.Select(q => q.OrderBy(x => x).ToList())
                                .OrderBy(q => q[0]).ThenBy(q => q[1]).ThenBy(q => q[2]).ThenBy(q => q[3])
                                .ToList();
        var expectedSorted = expected.Select(q => q.OrderBy(x => x).ToList())
                                     .OrderBy(q => q[0]).ThenBy(q => q[1]).ThenBy(q => q[2]).ThenBy(q => q[3])
                                     .ToList();

        for (int i = 0; i < actualSorted.Count; i++)
        {
            if (!actualSorted[i].SequenceEqual(expectedSorted[i]))
            {
                return false;
            }
        }
        return true;
    }

    [Fact]
    public void StandardCase_ReturnsCorrectQuadruplets()
    {
        // Arrange
        int[] nums = [1, 0, -1, 0, -2, 2];
        int target = 0;
        var expected = new List<IList<int>>
        {
            new List<int> { -2, -1, 1, 2 },
            new List<int> { -2, 0, 0, 2 },
            new List<int> { -1, 0, 0, 1 }
        };

        // Act
        var result = FourSum.FindFourSum(nums, target);

        // Assert
        Assert.True(AreQuadrupletsEqual(result, expected), "Standard case failed.");
    }

    [Fact]
    public void EmptyArray_ReturnsEmptyList()
    {
        // Arrange
        int[] nums = [];
        int target = 0;
        var expected = new List<IList<int>>();

        // Act
        var result = FourSum.FindFourSum(nums, target);

        // Assert
        Assert.True(AreQuadrupletsEqual(result, expected), "Empty array case failed.");
    }

    [Fact]
    public void SmallArray_ReturnsEmptyList()
    {
        // Arrange
        int[] nums = [1, 2, 3];
        int target = 12;
        var expected = new List<IList<int>>();

        // Act
        var result = FourSum.FindFourSum(nums, target);

        // Assert
        Assert.True(AreQuadrupletsEqual(result, expected), "Small array case failed.");
    }

    [Fact]
    public void NoSolution_ReturnsEmptyList()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4];
        int target = 100;
        var expected = new List<IList<int>>();

        // Act
        var result = FourSum.FindFourSum(nums, target);

        // Assert
        Assert.True(AreQuadrupletsEqual(result, expected), "No solution case failed.");
    }

    [Fact]
    public void Duplicates_ReturnsUniqueQuadruplets()
    {
        // Arrange
        int[] nums = [0, 0, 0, 0, 0, 0];
        int target = 0;
        var expected = new List<IList<int>>
        {
            new List<int> { 0, 0, 0, 0 }
        };

        // Act
        var result = FourSum.FindFourSum(nums, target);

        // Assert
        Assert.True(AreQuadrupletsEqual(result, expected), "Duplicates case failed.");
    }

}