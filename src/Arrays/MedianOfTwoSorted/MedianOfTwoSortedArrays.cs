namespace CodingChallenges.Arrays;
public class MedianOfTwoSortedArrays
{
    public static void Run()
    {
        int[] nums1 = [2, 7, 11, 15];
        int[] nums2 = [2, 7, 11, 15];
        var result = FindMedianSortedArrays(nums1, nums2);
        Console.WriteLine($"Median: {result}");
        var result2 = FindMedianSortedArraysUsingBinarySearch(nums1, nums2);
        Console.WriteLine($"Median using binary search: {result2}");
    }

    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int n = nums1.Length + nums2.Length;
        int[] merged = new int[n];
        int i = 0, j = 0, k = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                merged[k++] = nums1[i++];
            }
            else
            {
                merged[k++] = nums2[j++];
            }
        }

        while (i < nums1.Length)
        {
            merged[k++] = nums1[i++];
        }

        while (j < nums2.Length)
        {
            merged[k++] = nums2[j++];
        }

        if (n % 2 == 0)
        {
            return (merged[n / 2 - 1] + merged[n / 2]) / 2.0;
        }
        else
        {
            return merged[n / 2];
        }
    }

    public static double FindMedianSortedArraysUsingBinarySearch(int[] nums1, int[] nums2)
    {
        // Make sure nums1 is the smaller array
        if (nums1.Length > nums2.Length) return FindMedianSortedArraysUsingBinarySearch(nums2, nums1);


        int m = nums1.Length;
        int n = nums2.Length;
        int totalLeft = (m + n + 1) / 2;

        int low = 0;
        int high = m;

        while (low <= high)
        {
            int part1 = (low + high) / 2;       // Partition index for nums1
            int part2 = totalLeft - part1;            // Partition index for nums2

            int left_1 = (part1 == 0) ? int.MinValue : nums1[part1 - 1];
            int right_1 = (part1 == m) ? int.MaxValue : nums1[part1];

            int left_2 = (part2 == 0) ? int.MinValue : nums2[part2 - 1];
            int right_2 = (part2 == n) ? int.MaxValue : nums2[part2];

            if (left_1 <= right_2 && left_2 <= right_1)
            {
                // Correct partition
                if ((m + n) % 2 == 0)
                {
                    return (Math.Max(left_1, left_2) + Math.Min(right_1, right_2)) / 2.0;
                }
                else
                {
                    return Math.Max(left_1, left_2);
                }
            }
            else if (left_1 > right_2)
            {
                high = part1 - 1;
            }
            else
            {
                low = part1 + 1;
            }
        }

        throw new ArgumentException("Input arrays are not sorted properly.");
    }
}
