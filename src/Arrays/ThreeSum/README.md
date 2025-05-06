# 3Sum Problem

## Problem Statement

Given an integer array `nums`, return all the **unique triplets** `[nums[i], nums[j], nums[k]]` such that:

- `i != j`, `j != k`, and `i != k`
- `nums[i] + nums[j] + nums[k] == 0`

The result must not contain duplicate triplets.

---

## Example

**Input:**

```
nums = [-1, 0, 1, 2, -1, -4]
```

**Output:**

```
[[-1, -1, 2], [-1, 0, 1]]
```

---

## Approach

We solve the problem using a **two-pointer** approach after sorting the array. The steps are:

1. **Sort** the array.
2. Loop through each number in the array with index `i`.
3. For each `i`, use two pointers `left` (i + 1) and `right` (end of array).
4. Calculate the sum:
   - If the sum is 0: we found a triplet.
   - If the sum is less than 0: move the left pointer to the right.
   - If the sum is greater than 0: move the right pointer to the left.
5. Skip any duplicates to avoid repeated triplets.

---

## Time and Space Complexity

- **Time Complexity:** O(n²) — for each element, we search the rest of the array using two pointers.
- **Space Complexity:** O(1) — ignoring the space required for the output list.

---

## Notes

- Sorting the array helps in efficiently skipping duplicates and using the two-pointer technique.
- Be cautious about skipping duplicate values for both `i`, `left`, and `right`.

---

## Tags

`Array`, `Two Pointers`, `Sorting`
