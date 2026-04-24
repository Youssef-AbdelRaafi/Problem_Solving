# 📈 Best Time to Buy and Sell Stock

| Property | Value |
|----------|-------|
| **LeetCode #** | [121. Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/) |
| **Difficulty** | 🟢 Easy |
| **Category** | Arrays, Greedy |

---

## 📝 Problem Statement

Given an array `prices` where `prices[i]` is the price of a stock on the `iᵗʰ` day, find the **maximum profit** from a single buy-sell transaction. If no profit is possible, return `0`.

**Example:**

```
Input:  prices = [7, 1, 5, 3, 6, 4]
Output: 5
Explanation: Buy on day 2 (price = 1), sell on day 5 (price = 6) → profit = 5
```

---

## 💡 Approach — Greedy (Track Minimum Price)

1. Initialize `minPrice = int.MaxValue` and `maxProfit = 0`.
2. For each price:
   - If it's **lower** than `minPrice` → update `minPrice`.
   - Otherwise → compute `profit = price - minPrice` and update `maxProfit` if larger.
3. Return `maxProfit`.

**Key Insight:** Always buy at the lowest point seen so far, sell at the highest point after that.

---

## ⏱️ Complexity

| Metric | Value |
|--------|-------|
| **Time** | `O(n)` — single pass |
| **Space** | `O(1)` — two variables |

---

## 🖥️ Solution

```csharp
int MaximumProfit(int[] prices)
{
    int minPrice = int.MaxValue;
    int maxProfit = 0;

    for (int i = 0; i < prices.Length; i++)
    {
        if (prices[i] < minPrice)
        {
            minPrice = prices[i];
        }
        else
        {
            int profit = prices[i] - minPrice;

            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }
    }

    return maxProfit;
}
```
