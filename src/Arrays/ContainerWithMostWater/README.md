# Container With Most Water

## Problem Statement

You are given an integer array `height` of length `n`, where each element represents the height of a vertical line at that index. Your task is to find two lines that, together with the x-axis, form a container that can hold the most water.

**Note**: You cannot slant the container.

## Key Points

- The container's height is determined by the shorter of the two lines
- The container's width is the distance between the two lines (their indices)
- The area is calculated as: `area = min(height[left], height[right]) * (right - left)`

## Example

For the input `[1,8,6,2,5,4,8,3,7]`:

- The maximum area is between the lines at indices 1 (height 8) and 8 (height 7)
- Width = 8 - 1 = 7
- Height = min(8, 7) = 7
- Area = 7 \* 7 = 49

## Optimal Solution Approach

The most efficient solution uses a **two-pointer technique**:

1. Initialize two pointers at both ends of the array
2. Calculate the current area
3. Move the pointer pointing to the shorter line inward
4. Keep track of the maximum area found
5. Repeat until the pointers meet

**Why it works**: By always moving the shorter line, we're potentially finding a taller line that could lead to a larger area, while systematically eliminating less optimal pairs.

## Complexity Analysis

- **Time Complexity**: O(n) - We only pass through the array once
- **Space Complexity**: O(1) - We only use constant extra space
