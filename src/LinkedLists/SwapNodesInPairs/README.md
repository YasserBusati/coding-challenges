# Swap Nodes in Pairs

## Problem Statement

Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

### 🔸 Example

```text
Input: 1 -> 2 -> 3 -> 4
Output: 2 -> 1 -> 4 -> 3
```

```text
Input: []
Output: []
```

```text
Input: [1]
Output: [1]
```

## 💡 Approach

### 🔸 Intuition

The problem requires swapping adjacent nodes in pairs. The key challenge is to manipulate the node pointers correctly to perform the swaps while maintaining the integrity of the linked list structure.

### 🔸 Algorithm

1.  **Dummy Node Technique **:

- Use a dummy node at the beginning of the list to simplify edge cases (empty list or single-node list).
- This dummy node acts as a placeholder to ensure consistent handling of the head node during swaps.

2.  **Iterative Swapping **:

- Traverse the list while there are at least two nodes left to swap.
- For each pair of nodes:
- Identify the two nodes to be swapped (`first` and `second`).
- Adjust the next pointers to perform the swap:
  - The `first` node should point to the node after second.
  - The `second` node should point back to first.
  - The previous node (before the pair) should now point to second.
- Move the pointer forward by two nodes to process the next pair.

3.  **Termination Condition **:

- The loop continues as long as there are at least two more nodes to swap (current.next != null && current.next.next != null).

## 🕒 Complexity Analysis

- Time Complexity: O(n), where n is the number of nodes in the linked list. Each node is processed exactly once.
- Space Complexity: O(1), as the algorithm uses a constant amount of extra space regardless of the input size.

## ✅ Edge Cases

- Empty list (return null).
- Single-node list (return the list as-is).
- Odd-length list (the last node remains unchanged).
