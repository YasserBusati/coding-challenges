# 🔀 Zigzag Conversion - C# Solution

This repository contains the C# implementation of the classic **Zigzag Conversion** problem, frequently asked in coding interviews (e.g., on LeetCode).

## 📝 Problem Statement

The string is written in a zigzag pattern on a given number of rows like this:

```
Input: s = "PAYPALISHIRING", numRows = 3

Pattern: P A H N
A P L S I I G
Y I R

Output (row by row): "PAHNAPLSIIGYIR"
```

### 🧠 Objective

Given a string `s` and an integer `numRows`, arrange the string in a zigzag pattern on `numRows` and then read it row by row.

---

## 💡 Approach

1. Use a list of `StringBuilder` objects, one for each row.
2. Traverse the input string:
   - Append characters to the appropriate row.
   - Switch direction (up or down) when reaching the top or bottom row.
3. Combine all rows at the end to form the result.

---

## ⚠️ Important Note About StringBuilder

When creating the array of `StringBuilder` objects using:

```csharp
var rows = new StringBuilder[numRows];
```

This only creates an array of null references initially.
Memory looks like:

```csharp
rows = [
  null,
  null,
  null
]

```

Each element in the array must be explicitly initialized before use:

for (int i = 0; i < numRows; i++)
rows[i] = new StringBuilder();

Failing to do so will result in a NullReferenceException when attempting to call .Append() on a null element.

✅ After Initialization

```csharp
rows = [
  StringBuilder -> "",
  StringBuilder -> "",
  StringBuilder -> ""
]

```

Each StringBuilder is ready to hold characters.

🧲 As Characters Are Appended
Let’s say characters are appended in this order:

```csharp
rows[0].Append('P');
rows[1].Append('A');
rows[2].Append('Y');
rows[1].Append('P');
rows[0].Append('A');

```

Then the array looks like this:

```csharp
rows = [
  StringBuilder -> "PA",
  StringBuilder -> "AP",
  StringBuilder -> "Y"
]

```
