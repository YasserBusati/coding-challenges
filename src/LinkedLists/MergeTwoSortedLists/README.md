# Merge Two Sorted Lists

## Problem Statement

Given the heads of two sorted linked lists `list1` and `list2`, merge them into one **sorted** linked list and return the head of the merged list.

**Example:**
Input: list1 = [1,3,5], list2 = [2,4,6]
Output: [1,2,3,4,5,6]

## Approach

1. **Dummy Node:** Use a dummy node to simplify edge-case handling.
2. **Iterative Comparison:** Compare nodes from both lists and link the smaller value to the merged list.
3. **Append Remaining:** Attach any leftover nodes directly to the merged list.
