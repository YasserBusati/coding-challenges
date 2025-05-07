# Three Sum Closest

## Problem Description

Given an integer array `nums` of length `n` and an integer `target`, find three integers in `nums` such that the sum is closest to `target`. Return the sum of the triplet.

### Example

**Input:** `nums = [-1, 2, 1, -4]`, `target = 1`  
**Output:** `2`  
**Explanation:** The sum that is closest to the target is `2` (`-1 + 2 + 1 = 2`).

## Solution Approach

### Optimal Strategy (Two Pointers)

1. **Sort the Array**:

   - Enables efficient searching using the two-pointer technique
   - Time: O(n log n)

2. **Initialize Tracking**:

   - Start with the sum of first three elements as initial closest sum

3. **Two-Pointer Search**:

   - For each element `nums[i]` (from start to 3rd last):
     - Set `left` pointer at `i+1`
     - Set `right` pointer at last element
     - While `left < right`:
       - Calculate current triplet sum
       - Update closest sum if current is closer to target
       - If sum < target: move `left` right (increase sum)
       - If sum > target: move `right` left (decrease sum)
       - If exact match found: return immediately

We measure how close a triplet sum is to the target using absolute difference:

```math
distance = |currentSum - target|
```

4. **Return Result**:
   - After checking all possible triplets, return the closest sum found

## Complexity Analysis

- **Time:** O(n²)
  - Sorting: O(n log n)
  - Nested loop: O(n²)
- **Space:** O(1) (ignoring sorting space)

## Key Insights

- Sorting transforms the problem from O(n³) brute force to O(n²)
- Two-pointer technique efficiently narrows search space
- Early termination when exact match is found optimizes best-case scenario

## Edge Cases Handled

- Arrays with all positive/negative numbers
- Multiple valid solutions
- Exact match exists vs closest approximation
- Small (n=3) and large input arrays
