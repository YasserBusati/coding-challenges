# Two Sum Problem

## Problem

Given an array of integers `nums` and an integer `target`, return the **indices** of the two numbers that add up to the `target`.

### Example

**Input:**  
`nums = [2, 7, 11, 15]`  
`target = 9`

**Output:**  
`[0, 1]` (because `nums[0] + nums[1] = 2 + 7 = 9`)

---

## Solution Approach (Brute Force)

### Key Idea

- Check **every possible pair** in the array.
- If their sum matches the `target`, return their indices.

### Steps

1. **Loop through each element** (`i` from `0` to `n-1`).
2. **Nested loop** (`j` from `i+1` to `n-1`) to check pairs.
3. If `nums[i] + nums[j] == target`, return `[i, j]`.
4. If no pair found, return an empty array.

### Complexity

- **Time:** `O(n²)` (worst case checks all possible pairs).
- **Space:** `O(1)` (no extra space used).
