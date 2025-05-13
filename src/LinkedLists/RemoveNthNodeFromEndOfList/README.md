# Remove Nth Node From End of List

## Problem Description

Given a singly linked list and an integer `n`, remove the Nth node from the end and return the modified list's head. For example:

- Input: `1->2->3->4->5`, `n = 2`
- Output: `1->2->3->5`

## Approach

The solution uses the **two-pointer technique** with a dummy node to handle edge cases (e.g., removing the head). Here's how it works:

1. Create a dummy node pointing to the head to simplify edge cases.
2. Initialize two pointers, `fast` and `slow`, at the dummy node.
3. Move `fast` `n` steps ahead to create a gap of `n` nodes.
4. Move both pointers one step at a time until `fast` reaches the end. At this point, `slow` is at the node just before the one to delete.
5. Update `slow.next` to skip the target node.
6. Return `dummy.next` as the modified list's head.

This approach ensures a single pass through the list and handles cases like single-node lists or removing the head.
