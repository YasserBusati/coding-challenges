# Longest Common Prefix

## Problem Statement

Given an array of strings, find the longest common prefix (LCP) among them. If there is no common prefix, return an empty string `""`.

## Solution Approaches

### 1. Horizontal Scanning Approach

#### How It Works:

1. **Initialization**: Takes the first string as the initial prefix
2. **Iteration**: Compares the prefix with each subsequent string
3. **Prefix Reduction**: If the prefix isn't found at the start of a string, reduces it by one character from the end
4. **Early Exit**: Returns immediately if the prefix becomes empty

#### Complexity Analysis:

- **Time Complexity**: O(S), where S is the sum of all characters in all strings
- **Space Complexity**: O(1) (constant extra space)
- **Best Case**: All strings are identical
- **Worst Case**: All strings are completely different

### 2. Sorting & First/Last Comparison Approach

#### How It Works:

1. **Sorting**: Sorts the array lexicographically
2. **Comparison**: Compares only the first and last strings after sorting
3. **Character Matching**: Finds the matching prefix between first and last strings

#### Complexity Analysis:

- **Time Complexity**: O(n log n) for sorting + O(m) for comparison
- **Space Complexity**: O(1) (no extra space beyond sorting)
- **Best Case**: Few strings with long common prefix
- **Worst Case**: Many strings with no common prefix

## Performance Comparison

| Approach                | Time Complexity | Best For                       | Worst For                    |
| ----------------------- | --------------- | ------------------------------ | ---------------------------- |
| **Horizontal Scanning** | O(S)            | Few long strings               | Many different strings       |
| **Sorting + Compare**   | O(n log n + m)  | Many strings with short prefix | Few strings with long prefix |
