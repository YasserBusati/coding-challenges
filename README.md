# coding-challenges
Welcome to the C# Coding Challenges repository! 🚀 This repository contains solutions to various coding problems from platforms like LeetCode, CodeForces, and more. It is structured to help you organize, run, and test solutions efficiently while keeping the repository scalable.

# Repository Structure
```
coding-challenges/
│── README.md
│── .gitignore
│── src/
│   │── LeetCode/
│   │   │── Arrays/
│   │   │   │── TwoSum.cs
│   │   │   │── MergeSortedArray.cs
│   │   │── Strings/
│   │   │── LinkedLists/
│   │── Codeforces/
│   │   │── Div2/
│   │   │   │── Problem1872A.cs
│   │── HackerRank/
│   │── ProjectEuler/
│── tests/
│   │── LeetCodeTests/
│   │   │── TwoSumTests.cs
│   │── CodeforcesTests/
│── docs/ (Optional)
│── solutions.md
│── Algorithms/
│   │── Sorting/
│   │   │── QuickSort.cs
│   │   │── MergeSort.cs
│   │── Searching/
│   │   │── BinarySearch.cs
│   │── DynamicProgramming/
│── DataStructures/
│   │── LinkedList.cs
│   │── Stack.cs
│   │── Queue.cs
│── CompetitiveProgramming/
│   │── BitManipulation.cs
│   │── MathTricks.cs
│   │── Graphs/
│   │   │── Dijkstra.cs
│   │   │── BFS.cs
│── SystemDesign/
│   │── LowLevel/
│   │── HighLevel/
```

# 🚀 Running Problems Dynamically

This repository supports dynamic execution of coding problems without modifying `Program.cs` every time. You can run any problem by simply passing its name as an argument or entering it interactively.

---

## 📌 How It Works

1️⃣ Each problem is implemented as a **C# class** with a **`Run()` method**.  
2️⃣ The `ProblemRunner` class uses **reflection** to locate and execute the problem dynamically.  
3️⃣ Problems are structured under different categories (e.g., `LeetCode`, `CodeForces`).  
4️⃣ You can run a problem using the **CLI** or interactively.  

---

## 🎯 Running a Problem

### 🔹 Method 1: Command Line Execution
Run a specific problem by passing its **fully qualified class name**:

```sh
dotnet run LeetCode.Arrays.TwoSum
```
✔ This will locate and execute `TwoSum.cs` from the `LeetCode.Arrays` namespace.

---

### 🔹 Method 2: Interactive Mode
If no problem name is provided, the program will prompt you:
```sh
dotnet run
```
Then enter the problem name manually:
```
Enter the problem name: LeetCode.Arrays.TwoSum
```

---

## 🛠 Example Problem Implementation

Here’s how a problem should be structured:

```csharp
namespace LeetCode.Arrays
{
    public class TwoSum
    {
        public static void Run()
        {
            Console.WriteLine("Solving TwoSum problem...");
        }
    }
}
```
✔ This ensures `ProblemRunner` can find and execute it.

---

## 🚀 How `ProblemRunner` Works

The `ProblemRunner` class:  
✅ **Searches** for the class dynamically using reflection.  
✅ **Finds and invokes** the `Run()` method.  
✅ **Handles errors gracefully** if the problem is not found or has no `Run()` method.  

---

## 📌 Why This Approach?
✔ **No need to modify `Program.cs` for every new problem**  
✔ **Supports multiple problem categories (LeetCode, CodeForces, etc.)**  
✔ **Can be run via CLI or interactively**  
✔ **Scalable and maintainable**  

---



