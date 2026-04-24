# 🔢 Two Sum

| Property | Value |
|----------|-------|
| **LeetCode #** | [1. Two Sum](https://leetcode.com/problems/two-sum/) |
| **Difficulty** | 🟢 Easy |
| **Category** | Arrays, Hash Map |

---

## 📝 Problem Statement

Given an array of integers `nums` and an integer `target`, return **indices of the two numbers** such that they add up to `target`.

You may assume that each input would have **exactly one solution**, and you may not use the same element twice.

**Example:**

```
Input:  nums = [2, 7, 11, 15], target = 9
Output: [0, 1]
Explanation: nums[0] + nums[1] == 9 → return [0, 1]
```

---

## 💡 Approach — Hash Map (One-Pass)

1. Iterate through the array while maintaining a **Dictionary** that maps each visited value to its index.
2. For each element, compute `complement = target - nums[i]`.
3. If the complement already exists in the dictionary → return both indices.
4. Otherwise, store the current element and its index.

This replaces the brute-force `O(n²)` nested-loop with a single-pass lookup.

---

## ⏱️ Complexity

| Metric | Value |
|--------|-------|
| **Time** | `O(n)` — single pass |
| **Space** | `O(n)` — dictionary storage |

---

## 🖥️ Solution

```csharp
int[] TwoSum(int[] num, int target)
{
    Dictionary<int, int> keyValues = new Dictionary<int, int>();

    int n = num.Length;
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        int result = target - num[i];

        if (keyValues.ContainsKey(result))
        {
            arr = new int[] { keyValues[result], i };
        }
        else
        {
            keyValues.Add(num[i], i);
        }
    }

    return arr;
}
```
