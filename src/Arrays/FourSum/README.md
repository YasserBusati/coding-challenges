# 4Sum Problem

## Problem Description

Given an array `nums` of integers and an integer `target`, find all unique quadruplets `[nums[a], nums[b], nums[c], nums[d]]` such that:

- `0 <= a, b, c, d < nums.Length`
- `a`, `b`, `c`, `d` are distinct indices
- `nums[a] + nums[b] + nums[c] + nums[d] == target`

The solution returns a list of all unique quadruplets that satisfy the condition.

## Approach

The solution uses a **sorting + two-pointer** technique, extending the approach from the 2Sum and 3Sum problems. Here's the step-by-step approach:

1. **Sort the Array**: Sorting enables efficient use of two pointers and simplifies duplicate handling.
2. **Nested Loops for First Two Elements**: Iterate over the first two elements (`i` and `j`) of the quadruplet using two loops.
3. **Two-Pointer Technique for Remaining Elements**: For each pair `(i, j)`, use two pointers (`left` and `right`) to find two numbers that sum to the remaining target (`target - nums[i] - nums[j]`).
4. **Handle Duplicates**: Skip duplicate values at each level (for `i`, `j`, `left`, and `right`) to ensure unique quadruplets.
5. **Optimizations**:
   - **Early Termination**: Break or skip iterations if the smallest or largest possible sums (using the sorted array) cannot reach the target.
   - **Use `long` for Sums**: Prevent integer overflow by using `long` for intermediate sum calculations.

## Time and Space Complexity

- **Time Complexity**: \(O(n^3)\), where \(n\) is the array length. The two nested loops contribute \(O(n^2)\), and the two-pointer technique takes \(O(n)\) for each pair.
- **Space Complexity**: \(O(1)\) excluding the output list, ignoring the \(O(\log n)\) space used by the sorting algorithm.
