# Generate Parentheses

## Problem Description

Given an integer `n`, generate all combinations of well-formed parentheses with `n` pairs.

**Example:**

Input: `n = 3`
Output:

```
[
"((()))",
"(()())",
"(())()",
"()(())",
"()()()"
]
```

## Approach

We use **backtracking** to solve this problem efficiently. The key idea is to:

1. Only add `'('` if we haven't used all `n` opening parentheses
2. Only add `')'` if we have more opening than closing parentheses
3. Stop when the string length reaches `2*n`

### Key Steps:

1. Start with an empty string and counters for open/close parentheses
2. Recursively build valid combinations:
   - Add `'('` if possible
   - Add `')'` if valid
3. Add to results when a complete valid combination is formed

## Complexity

- **Time:** O(4^n/√n) (Catalan number)
- **Space:** O(n) for recursion stack

## Example

For `n = 2`:
`["(())", "()()"]`
