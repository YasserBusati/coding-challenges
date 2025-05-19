# Merge k Sorted Lists

## 🧩 Problem Statement

You are given an array of `k` linked lists, each linked list is sorted in ascending order. Your task is to merge all the linked lists into one sorted linked list and return its head.

### 🔸 Example

```text
Input:  lists = [[1,4,5],[1,3,4],[2,6]]
Output: [1,1,2,3,4,4,5,6]
```

---

## 💡 Approach

We can solve this efficiently using a **Min-Heap (Priority Queue)**. The idea is to always pick the smallest node from the current heads of the k lists.

### Steps:

1. Create a min-heap (priority queue) that compares nodes based on their values.
2. Add the head of each linked list into the priority queue.
3. Create a dummy node to act as the start of the result linked list.
4. While the priority queue is not empty:
   - Extract the smallest node from the heap.
   - Append it to the merged list.
   - If the extracted node has a `next` node, insert it into the heap.
5. Return the merged list starting from the dummy node’s next pointer.

---

## 🕒 Time and Space Complexity

- **Time Complexity:** `O(N log k)`

  - `N` is the total number of nodes across all linked lists.
  - `log k` is the time to maintain the heap with `k` elements.

- **Space Complexity:** `O(k)` for the heap storage.

---

## ✅ Constraints

- The number of linked lists `k` is in the range `[0, 10^4]`.
- The number of nodes in each linked list is in the range `[0, 500]`.
- `-10^4 <= Node.val <= 10^4`

---
