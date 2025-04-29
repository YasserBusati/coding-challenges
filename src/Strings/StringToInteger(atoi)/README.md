# String to Integer (atoi)

## 📝 Problem Statement

Implement the `MyAtoi(string s)` function that converts a string to a 32-bit signed integer (like the C/C++ `atoi` function).

The function should:

1. Ignore leading whitespace.
2. Handle an optional `+` or `-` sign.
3. Read in digits until the first non-digit character or the end of the string.
4. Clamp the result to the 32-bit signed integer range:
   - **[-2³¹, 2³¹ - 1]** → **[-2147483648, 2147483647]**

If the number is out of this range, return `Int32.MaxValue` or `Int32.MinValue`.

If no valid conversion can be performed, return `0`.

---

## ✅ Examples

| Input               | Output        |
| ------------------- | ------------- |
| `"42"`              | `42`          |
| `"   -42"`          | `-42`         |
| `"4193 with words"` | `4193`        |
| `"words and 987"`   | `0`           |
| `"-91283472332"`    | `-2147483648` |

---

## 🧠 Approach

- Skip leading whitespaces.
- Check and handle an optional sign.
- Use `s[index] - '0'` to extract digit values from characters.
- Multiply and accumulate while checking for overflow:
  - If `result > (Int32.MaxValue - digit) / 10`, return clamped value.

---

### Overflow Detection Logic

The critical overflow check prevents integer overflow by verifying two conditions before performing multiplication and addition:

```csharp
 // Check for overflow
    if (result > int.MaxValue / 10 ||
        (result == int.MaxValue / 10 && digit > int.MaxValue % 10))
    {
        return sign == 1 ? int.MaxValue : int.MinValue;
    }
```

1. **Pre-multiplication Check**

   - Compares current result against `int.MaxValue / 10` (214748364 for 32-bit integers)
   - If current result exceeds this, multiplying by 10 would cause overflow

2. **Edge Case Check**
   - When current result equals 214748364, verifies the next digit
   - Any digit > 7 (last digit of INT_MAX) would cause overflow
   - Returns INT_MAX for positive overflow, INT_MIN for negative overflow

### Visual Example

For input "2147483648":

1. After processing "214748364":
   - Next digit is '8'
2. Check:
   - Current result equals threshold (214748364)
   - Digit (8) exceeds maximum last digit (7)
3. Returns INT_MAX (2147483647)

## Complexity Analysis

- **Time Complexity**: O(n) - Single pass through the string
- **Space Complexity**: O(1) - Constant extra space used
