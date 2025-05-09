# Letter Combinations of a Phone Number

This project solves the **Letter Combinations of a Phone Number** problem using **C# and backtracking**.

## 🚀 Problem Statement

Given a string containing digits from `2-9` inclusive, return all possible letter combinations that the number could represent based on the telephone keypad mapping.

### 🔢 Digit to Letters Mapping

```
2 -> abc
3 -> def
4 -> ghi
5 -> jkl
6 -> mno
7 -> pqrs
8 -> tuv
9 -> wxyz
```

### ✅ Example

**Input:** `"23"`  
**Output:** `["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"]`

---

## 💡 Approach

This solution uses **backtracking (recursive DFS)** to explore all combinations:

1. Use a dictionary to map each digit to its corresponding letters.
2. Start from the first digit and pick one letter at a time.
3. Recurse into the next digit until the length of the current string equals the input length.
4. Add valid combinations to the result list.
