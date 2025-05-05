# Roman Numeral Converter to Integer

Converts Roman numeral strings to integers with proper handling of:

- Additive notation (III = 3)
- Subtractive notation (IV = 4)
- Complex combinations (MCMXCIV = 1994)

## Conversion Approach

1. We read the Roman numeral **backwards** (right to left)
2. For each letter:
   - If it's **smaller** than the last letter we saw → subtract its value
   - If it's **equal or larger** → add its value
3. Example for "IX":
   - First 'X' (10) → add 10 (total = 10)
   - Then 'I' (1) → 1 < 10 → subtract 1 (total = 9)

### How Subtraction Works

1. **Initialization**:

   - Start with a total of 0
   - Keep track of the previous value (initially 0)

2. **Right-to-Left Processing**:
   For each symbol (starting from the end):
   - Get the integer value of the current symbol
   - Compare it with the previous symbol's value:
     - If current value < previous value → **Subtract** current value from total
     - Else → **Add** current value to total
   - Update previous value to current value

### Example: "MCMXCIV" (1994)

| Symbol | Value | Comparison  | Action | Total |
| ------ | ----- | ----------- | ------ | ----- |
| V      | 5     | 0 < 5?      | +5     | 5     |
| I      | 1     | 1 < 5?      | -1     | 4     |
| C      | 100   | 100 < 1?    | +100   | 104   |
| X      | 10    | 10 < 100?   | -10    | 94    |
| M      | 1000  | 1000 < 10?  | +1000  | 1094  |
| C      | 100   | 100 < 1000? | -100   | 994   |
| M      | 1000  | 1000 < 100? | +1000  | 1994  |

## Features

- Convert Roman numerals to Integer (I-MMMCMXCIX)
