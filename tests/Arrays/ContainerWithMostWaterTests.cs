using CodingChallenges.Arrays.ContainerWithMostWater;

namespace tests.Arrays;

public class ContainerWithMostWaterTests
{
    [Fact]
    public void MaxArea_RegularCase_ReturnsCorrectArea()
    {
        int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];

        int result = ContainerWithMostWater.MaxArea(height);

        Assert.Equal(49, result);
    }

    [Fact]
    public void MaxArea_AllEqualHeight_ReturnsCorrectArea()
    {
        int[] height = [5, 5, 5, 5, 5];

        int result = ContainerWithMostWater.MaxArea(height);

        Assert.Equal(20, result);
    }

    [Fact]
    public void MaxArea_IncreasingHeight_ReturnsCorrectArea()
    {
        int[] height = [1, 2, 3, 4, 5];

        int result = ContainerWithMostWater.MaxArea(height);

        Assert.Equal(6, result);
    }

    [Fact]
    public void MaxArea_DecreasingHeight_ReturnsCorrectArea()
    {
        int[] height = [5, 4, 3, 2, 1];

        int result = ContainerWithMostWater.MaxArea(height);

        Assert.Equal(6, result);
    }

    [Fact]
    public void MaxArea_TwoElements_ReturnsCorrectArea()
    {
        int[] height = [3, 7];

        int result = ContainerWithMostWater.MaxArea(height);

        Assert.Equal(3, result);
    }

    [Fact]
    public void MaxArea_OneElement_ReturnsZero()
    {
        int[] height = [5];

        int result = ContainerWithMostWater.MaxArea(height);

        Assert.Equal(0, result);
    }

    [Fact]
    public void MaxArea_EmptyArray_ReturnsZero()
    {
        int[] height = [0];

        int result = ContainerWithMostWater.MaxArea(height);

        Assert.Equal(0, result);
    }

    [Fact]
    public void MaxArea_VShaped_ReturnsCorrectArea()
    {
        int[] height = [5, 1, 1, 1, 5];

        int result = ContainerWithMostWater.MaxArea(height);

        Assert.Equal(20, result);
    }

    [Fact]
    public void MaxArea_WithZeroHeight_ReturnsCorrectArea()
    {
        int[] height = [0, 2, 0, 4, 0];

        int result = ContainerWithMostWater.MaxArea(height);

        Assert.Equal(4, result);
    }
}