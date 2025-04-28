# Median of Two Sorted Arrays

## Problem Statement

Given two sorted arrays `nums1` and `nums2` of size `m` and `n` respectively, return the **median** of the two sorted arrays. The solution should have a time complexity of `O(log(min(m, n)))`.

### Example 1:

---

## 💡 Example

### Example 1:

Input: nums1 = [1, 3], nums2 = [2] Output: 2.00000 Explanation: The merged sorted array is [1, 2, 3] and the median is 2.

### Example 2:

Input: nums1 = [1, 2], nums2 = [3, 4] Output: 2.50000 Explanation: The merged sorted array is [1, 2, 3, 4] and the median is (2 + 3)/2 = 2.5.

### Example 3:

Input: nums1 = [0, 0], nums2 = [0, 0] Output: 0.00000 Explanation: The merged sorted array is [0, 0, 0, 0] and the median is 0.

### Example 4:

Input: nums1 = [], nums2 = [1] Output: 1.00000 Explanation: The merged sorted array is [1] and the median is 1.

### Constraints:

- `nums1.length == m`
- `nums2.length == n`
- `0 <= m <= 1000`
- `0 <= n <= 1000`
- `1 <= m + n <= 2000`
- `-10^6 <= nums1[i], nums2[i] <= 10^6`

## Approach

To solve this problem efficiently, we use a binary search algorithm. The idea is to partition the two arrays such that:

- The left partition contains elements smaller than or equal to the median.
- The right partition contains elements larger than or equal to the median.

We then ensure that the sizes of the two partitions are balanced and that the largest element in the left partition is smaller than the smallest element in the right partition.

### Steps:

1. **Identify the smaller array**: We always perform binary search on the smaller array to optimize time complexity.
2. **Partitioning**: Partition both arrays into two halves, where the left half contains elements smaller than or equal to the median, and the right half contains elements greater than or equal to the median.
3. **Check conditions**: We check the boundary conditions between the partitions to ensure the partitions are valid.
4. **Calculate median**: Depending on the total number of elements (even or odd), compute the median.
