# Add Two Numbers (Linked List)

## Problem

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in **reverse order**, and each node contains a single digit. Your task is to **add the two numbers** and return the sum as a linked list in the same reverse order format.

### Example

**Input:**  
`(2 → 4 → 3)` (represents `342`)  
`(5 → 6 → 4)` (represents `465`)

**Output:**  
`(7 → 0 → 8)` (represents `807`, because `342 + 465 = 807`)

---

## Solution Approach

### Key Idea

- Traverse both linked lists **simultaneously**.
- Add corresponding digits along with any **carry-over** from the previous addition.
- Build the result linked list step by step.

### Steps

1. Initialize a dummy node to build the result.
2. Use a `carry` variable to track overflow (initially `0`).
3. Loop until both lists are fully traversed **and** carry is `0`:
   - Sum the current digits from both lists (if they exist) and the carry.
   - Update `carry = sum / 10`.
   - Append the digit `(sum % 10)` to the result list.
4. Return the result (skip the dummy head).

### Complexity

- **Time:** `O(max(n, m))` (one pass through the longer list).
- **Space:** `O(max(n, m))` (for the result linked list).
