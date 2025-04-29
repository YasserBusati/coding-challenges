# Palindrome Number Checker - C# Solutions

This project provides two approaches to determine if an integer is a palindrome in C#. A palindrome number reads the same backward as forward (e.g., 121, 1331).

## Solution 1: String Conversion Method

### Approach

- Converts the integer to a string
- Uses two pointers (start and end) to compare characters
- Returns false if any mismatch is found during comparison
- Returns true if all character comparisons match

### Complexity

- **Time**: O(n) where n is the number of digits
- **Space**: O(n) due to string conversion

### Pros & Cons

- ✅ Simple and easy to understand
- ❌ Requires extra memory for string conversion
- ❌ Not the most optimal solution

## Solution 2: Mathematical Reversal (Optimal)

### Detailed Explanation

This approach reverses half of the number mathematically and compares it with the other half, avoiding string conversion.

#### Key Steps:

1. **Initial Checks**:

   - Negative numbers automatically fail (can't be palindromes)
   - Numbers ending with 0 (except 0 itself) fail (e.g., 10 → 01 isn't valid)

2. **Half Reversal Process**:

   - Initialize `reversedNumber` to 0
   - While the original number is greater than the reversed portion:
     - Take the last digit of the original number (`x % 10`)
     - Append it to `reversedNumber`
     - Remove the last digit from the original number (`x /= 10`)

3. **Final Comparison**:
   - For even-digit numbers: Compare `x` directly with `reversedNumber`
   - For odd-digit numbers: Compare `x` with `reversedNumber/10` (ignoring middle digit)

#### Why This Works:

- Only reverses half the digits needed for comparison
- Avoids potential overflow from full reversal
- Handles both even and odd length numbers elegantly

#### Complexity Analysis:

- **Time**: O(log₁₀ n) - We divide the number by 10 each iteration
- **Space**: O(1) - Uses constant extra space

#### Example Walkthrough (x = 12321):

1. Initial checks pass (positive, doesn't end with 0)
2. Loop iterations:
   - 1st: reversed=1, x=1232
   - 2nd: reversed=12, x=123
   - 3rd: reversed=123, x=12 (loop stops)
3. Final comparison: 12 == 123/10 → 12 == 12 → true

## Recommendation

Prefer **Solution 2** (Mathematical Reversal) due to its:

- Better space efficiency (no string conversion)
- Optimal time complexity
- Elegant handling of edge cases
