# 🧩 Valid Parentheses

### ✅ Problem

Given a string `s` containing just the characters:

- `'('`, `')'`
- `'{'`, `'}'`
- `'['`, `']'`

Determine if the input string is valid.

---

### 🧠 Rules for a Valid String

1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.
3. Every closing bracket must have a corresponding opening bracket before it.

---

### 💡 Approach: Using Stack (LIFO)

We use a **stack** to track opening brackets. For each character:

- If it’s an opening bracket, **push** it onto the stack.
- If it’s a closing bracket:
  - Check if the stack is empty (no matching opening) → **return false**
  - **Pop** the top of the stack and check if it matches the closing bracket.
  - If it doesn’t match → **return false**

If the stack is empty at the end, the string is **valid**.

**Examples**:

- `"()"` → `true`
- `"()[]{}"` → `true`
- `"(]"` → `false`
- `"([)]"` → `false`
- `"{"` → `false`
