## 🚀 Longest Palindromic Substring

### 🔗 LeetCode Link

[Longest Palindromic Substring – LeetCode #5](https://leetcode.com/problems/longest-palindromic-substring/)

---

### 🧩 Problem Statement

Given a string `s`, return **the longest palindromic substring** in `s`.

A **palindrome** is a string that reads the same backward as forward (e.g., `"madam"`, `"racecar"`).

---

### 🧠 Approach: Expand Around Center

- Every palindrome can be expanded from its center.
- A palindrome has either:
  - **Odd length** (e.g., center at `i`)
  - **Even length** (e.g., center between `i` and `i+1`)
- We expand from each center and keep track of the longest one found.

---

### 🧪 Examples

```text
Input:  s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.

Input:  s = "cbbd"
Output: "bb"
```
