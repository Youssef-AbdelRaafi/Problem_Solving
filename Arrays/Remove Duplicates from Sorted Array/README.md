# 🗑️ Remove Duplicates from Sorted Array

| Property | Value |
|----------|-------|
| **LeetCode #** | [26. Remove Duplicates from Sorted Array](https://leetcode.com/problems/remove-duplicates-from-sorted-array/) |
| **Difficulty** | 🟢 Easy |
| **Category** | Arrays, Two Pointers |

---

## 📝 Problem Statement

Given a sorted array `nums`, remove duplicates **in-place** so each element appears only once. Return `k` — the number of unique elements.

**Example:**

```
Input:  nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
Output: 5, nums = [0, 1, 2, 3, 4, _, _, _, _, _]
```

---

## 💡 Approach — Two Pointers

1. **Slow pointer** `k` at index `1` — tracks where to place the next unique element.
2. **Fast pointer** `i` scans the array.
3. When `nums[i] != nums[i - 1]` → copy `nums[i]` to position `k`, increment `k`.
4. Return `k`.

Since the array is sorted, duplicates are always adjacent — one pass is enough.

---

## ⏱️ Complexity

| Metric | Value |
|--------|-------|
| **Time** | `O(n)` — single pass |
| **Space** | `O(1)` — in-place |

---

## 🖥️ Solution

```csharp
int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0) return 0;

    int k = 1;
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i - 1])
        {
            nums[k] = nums[i];
            k++;
        }
    }

    return k;
}
```

> ⚠️ **Note:** Solution implementation in `Program.cs` is in progress.
