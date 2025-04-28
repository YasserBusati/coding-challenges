# Reverse Integer

## Problem

Given a signed 32-bit integer `x`, return `x` with its digits reversed.  
If reversing `x` causes the value to go outside the signed 32-bit integer range `[-2³¹, 2³¹ - 1]`, return `0`.

---

## Constraints

- `-2,147,483,648 <= x <= 2,147,483,647`
- Only 32-bit integers are allowed.

---

## Examples

| Input      | Output | Explanation                                    |
| :--------- | :----- | :--------------------------------------------- |
| 123        | 321    | Reverse of 123 is 321                          |
| -123       | -321   | Reverse of -123 is -321                        |
| 120        | 21     | Reverse of 120 is 21 (leading zero is removed) |
| 1534236469 | 0      | Reversing causes overflow                      |

---

## Approach

1. Initialize a variable `result` to 0.
2. While `x` is not 0:
   - Extract the last digit using modulus `% 10`.
   - Remove the last digit by doing integer division `/ 10`.
   - Before appending the digit, check if multiplying `result` by 10 and adding the digit would cause an overflow or underflow.
   - If safe, update `result` by `result = result * 10 + digit`.
3. Return `result`.

### Why use `%` and `/`?

- `% 10` gives the **last digit** of a number.
  - Example: `123 % 10 = 3`
- `/ 10` removes the **last digit** of a number.
  - Example: `123 / 10 = 12`
- This way, you peel off one digit at a time from the number starting from the right.

---

## Overflow and Underflow Check Explained

Before multiplying `result` by 10 and adding a digit, we need to ensure it will still fit within the 32-bit signed integer range.

### Overflow Check

```csharp
if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
    return 0;
```

- If result is already greater than int.MaxValue / 10 (which is 214748364), multiplying it by 10 would definitely overflow.

- If result is exactly equal to int.MaxValue / 10, then the next digit must be ≤ 7.

  - int.MaxValue is 2147483647, so the last digit is 7.

- If digit > 7, adding it would cause overflow.

### Underflow Check

```csharp
if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8))
    return 0;
```

- If result is already less than int.MinValue / 10 (which is -214748364), multiplying by 10 would underflow.

- If result is exactly equal to int.MinValue / 10, then the next digit must be ≥ -8.

  - int.MinValue is -2147483648, so the last digit is -8.

- If digit < -8, adding it would cause underflow.
