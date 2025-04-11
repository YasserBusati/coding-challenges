using CodingChallenges.Arrays;

namespace tests.Arrays;

public class MedianOfTwoSortedArraysTests
{

    [Fact]
    public void Test_FindMedianSortedArrays_EqualLengthArrays()
    {
        int[] nums1 = [2, 7, 11, 15];
        int[] nums2 = [2, 7, 11, 15];
        double expected = 9.0;

        double result1 = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        double result2 = MedianOfTwoSortedArrays.FindMedianSortedArraysUsingBinarySearch(nums1, nums2);

        Assert.Equal(expected, result1);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test_FindMedianSortedArrays_DifferentLengthArrays()
    {
        int[] nums1 = [1, 3, 8];
        int[] nums2 = [7, 9, 10, 11];
        double expected = 8.0;

        double result1 = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        double result2 = MedianOfTwoSortedArrays.FindMedianSortedArraysUsingBinarySearch(nums1, nums2);

        Assert.Equal(expected, result1);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test_FindMedianSortedArrays_EmptyArray()
    {
        int[] nums1 = [];
        int[] nums2 = [1, 2, 3, 4, 5];
        double expected = 3.0;

        double result1 = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        double result2 = MedianOfTwoSortedArrays.FindMedianSortedArraysUsingBinarySearch(nums1, nums2);

        Assert.Equal(expected, result1);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test_FindMedianSortedArrays_OddLengthArrays()
    {
        int[] nums1 = [1, 3, 8];
        int[] nums2 = [7, 9, 10, 11];
        double expected = 8.0;

        double result1 = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        double result2 = MedianOfTwoSortedArrays.FindMedianSortedArraysUsingBinarySearch(nums1, nums2);

        Assert.Equal(expected, result1);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test_FindMedianSortedArrays_EvenLengthArrays()
    {
        int[] nums1 = [1, 3, 8, 9];
        int[] nums2 = [2, 4, 5, 6];
        double expected = 4.5;

        double result1 = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        double result2 = MedianOfTwoSortedArrays.FindMedianSortedArraysUsingBinarySearch(nums1, nums2);

        Assert.Equal(expected, result1);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test_FindMedianSortedArrays_DisjointArrays()
    {
        int[] nums1 = [1, 3, 5, 7];
        int[] nums2 = [8, 9, 10, 11];
        double expected = 7.5;

        double result1 = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        double result2 = MedianOfTwoSortedArrays.FindMedianSortedArraysUsingBinarySearch(nums1, nums2);

        Assert.Equal(expected, result1);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test_FindMedianSortedArrays_LargeValues()
    {
        int[] nums1 = [1000000, 2000000, 3000000];
        int[] nums2 = [1500000, 2500000, 3500000];
        double expected = 2250000.0;

        double result1 = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        double result2 = MedianOfTwoSortedArrays.FindMedianSortedArraysUsingBinarySearch(nums1, nums2);

        Assert.Equal(expected, result1);
        Assert.Equal(expected, result2);
    }



}