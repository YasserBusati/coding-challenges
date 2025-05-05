# Integer to Roman Converter

## Problem Description

This converts an integer to its corresponding Roman numeral representation. Roman numerals are represented by combinations of letters from the Latin alphabet, with specific rules for construction and special subtraction cases.

## Roman Numeral Basics

Roman numerals use the following symbols:

- I = 1
- V = 5
- X = 10
- L = 50
- C = 100
- D = 500
- M = 1000

Numbers are typically formed by combining these symbols from largest to smallest value. However, there are special cases where subtraction is used:

- IV = 4 (5-1)
- IX = 9 (10-1)
- XL = 40 (50-10)
- XC = 90 (100-10)
- CD = 400 (500-100)
- CM = 900 (1000-100)

## Approach

The solution follows a systematic approach to convert integers to Roman numerals:

1. **Value-Symbol Mapping**:

   - Predefined pairs of integer values and their corresponding Roman numeral symbols
   - Includes both standard values (1, 5, 10, etc.) and special subtraction cases (4, 9, 40, etc.)
   - Ordered from largest to smallest value

2. **Iterative Conversion**:

   - Processes each value-symbol pair in descending order
   - For each pair, repeatedly subtracts the value from the input number and appends the corresponding symbol
   - Continues until the number is reduced to zero

3. **Efficiency**:
   - The algorithm operates in constant time O(1) since it uses a fixed set of value-symbol pairs
   - Space complexity is also O(1) as it uses a fixed amount of additional space

## Constraints

- The input integer must be between 1 and 3999 (inclusive)
- The solution handles all valid Roman numeral representations within this range

## Example Conversions

| Integer | Roman Numeral |
| ------- | ------------- |
| 3       | III           |
| 58      | LVIII         |
| 1994    | MCMXCIV       |
| 2023    | MMXXIII       |
| 3999    | MMMCMXCIX     |

## Usage

To use this converter, simply call the `IntToRoman` method with an integer between 1 and 3999. The method will return the corresponding Roman numeral string.

## Note

This implementation efficiently handles all valid conversions by leveraging the systematic nature of Roman numeral construction and the predefined value-symbol pairs.

## Features

- Convert Integer to Roman numerals (1-3999)
