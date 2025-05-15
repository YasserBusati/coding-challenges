# Merge Two Sorted Lists

## Problem Statement

Given the heads of two sorted linked lists `list1` and `list2`, we need to merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

## Approach

We'll use an iterative approach with a dummy head node to simplify edge cases.

## Step-by-Step Visual Explanation

### Initial Setup

```
list1: 1 -> 2 -> 4 -> null
list2: 1 -> 3 -> 4 -> null

dummy: -1
current: points to dummy
```

### Iteration 1:

Compare `list1.val` (1) and `list2.val` (1). They're equal, so we'll take from `list1`.

```
list1: 2 -> 4 -> null
list2: 1 -> 3 -> 4 -> null

dummy: -1 -> 1 -> ?
current: now points to the 1 from list1
```

### Iteration 2:

Compare `list1.val` (2) and `list2.val` (1). Since 1 < 2, take from `list2`.

```
list1: 2 -> 4 -> null
list2: 3 -> 4 -> null

dummy: -1 -> 1 -> 1 -> ?
current: now points to the 1 from list2
```

### Iteration 3:

Compare `list1.val` (2) and `list2.val` (3). Since 2 < 3, take from `list1`.

```
list1: 4 -> null
list2: 3 -> 4 -> null

dummy: -1 -> 1 -> 1 -> 2 -> ?
current: now points to the 2 from list1
```

### Iteration 4:

Compare `list1.val` (4) and `list2.val` (3). Since 3 < 4, take from `list2`.

```
list1: 4 -> null
list2: 4 -> null

dummy: -1 -> 1 -> 1 -> 2 -> 3 -> ?
current: now points to the 3 from list2
```

### Iteration 5:

Compare `list1.val` (4) and `list2.val` (4). They're equal, so we'll take from `list1`.

```
list1: null
list2: 4 -> null

dummy: -1 -> 1 -> 1 -> 2 -> 3 -> 4 -> ?
current: now points to the 4 from list1
```

### Final Step:

`list1` is null, but `list2` still has one node. Attach the remainder of `list2` to our result.

```
list1: null
list2: null (after appending remaining nodes)

dummy: -1 -> 1 -> 1 -> 2 -> 3 -> 4 -> 4 -> null
```

Our final result is `dummy.next`, which is the linked list `1 -> 1 -> 2 -> 3 -> 4 -> 4 -> null`.

## Time and Space Complexity

- **Time Complexity**: O(n + m) where n and m are the lengths of list1 and list2
- **Space Complexity**: O(1) since we only use a constant amount of extra space
