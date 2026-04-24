# ✖️ Product of Array Except Self

| Property | Value |
|----------|-------|
| **LeetCode #** | [238. Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/) |
| **Difficulty** | 🟡 Medium |
| **Category** | Arrays, Prefix & Suffix |

---

## 📝 Problem Statement

Given an integer array `nums`, return an array `answer` where `answer[i]` equals the **product of all elements except** `nums[i]`, **without using division**, in `O(n)` time.

**Example:**

```
Input:  nums = [1, 2, 3, 4]
Output: [24, 12, 8, 6]
```

---

## 💡 Approach — Prefix & Suffix Products (In-Place)

1. **Left pass (Prefix):** `answer[i]` = product of all elements to the **left** of `i`.
2. **Right pass (Suffix):** Multiply each `answer[i]` by a running suffix product from the right.

```
nums   = [1,  2,  3,  4]
prefix = [1,  1,  2,  6]   ← left pass
suffix = [24, 12, 4,  1]   ← right pass
answer = [24, 12, 8,  6]   ← prefix × suffix
```

---

## ⏱️ Complexity

| Metric | Value |
|--------|-------|
| **Time** | `O(n)` — two linear passes |
| **Space** | `O(1)` — output array + one variable |

---

## 🖥️ Solution

```csharp
int[] ProductOfArrayExceptSelf(int[] nums)
{
    int n = nums.Length;
    int[] answer = new int[n];

    // Left pass — prefix products
    answer[0] = 1;
    for (int i = 1; i < n; i++)
    {
        answer[i] = answer[i - 1] * nums[i - 1];
    }

    // Right pass — multiply by suffix products
    int suffix = 1;
    for (int i = n - 1; i >= 0; i--)
    {
        answer[i] *= suffix;
        suffix *= nums[i];
    }

    return answer;
}
```
